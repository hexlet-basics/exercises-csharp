FROM hexletbasics/base-image:latest

ENV DOTNET_CLI_TELEMETRY_OPTOUT=1 \
    DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1 \
    DOTNET_NOLOGO=1 \
    DOTNET_MULTILEVEL_LOOKUP=0 \
    DOTNET_CLI_HOME=/tmp/dotnet-cli \
    DOTNET_SCRIPT_CACHE_LOCATION=/tmp/dotnet-script-cache \
    DOTNET_GCHeapHardLimit=10000000 \
    DOTNET_ROOT=/usr/share/dotnet \
    PATH=/opt/dotnet-tools:/exercises-csharp/bin:$PATH

# Репозиторий Microsoft для Debian 12 не держит dotnet-sdk-8.0 под arm64,
# поэтому SDK ставит официальный dotnet-install.sh под обе архитектуры.
RUN apt-get update && \
    apt-get install -yqq ca-certificates unzip wget libicu72 libssl3 zlib1g && \
    rm -rf /var/lib/apt/lists/* && \
    wget -qO /tmp/dotnet-install.sh https://dot.net/v1/dotnet-install.sh && \
    bash /tmp/dotnet-install.sh --channel 8.0 --install-dir /usr/share/dotnet && \
    rm /tmp/dotnet-install.sh && \
    ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

RUN dotnet tool install --tool-path /opt/dotnet-tools dotnet-script --version 2.0.0 && \
    mkdir -p /opt/powerassert && \
    wget -qO /tmp/PowerAssert.1.0.87.nupkg https://www.nuget.org/api/v2/package/PowerAssert/1.0.87 && \
    unzip -q /tmp/PowerAssert.1.0.87.nupkg -d /opt/powerassert && \
    rm /tmp/PowerAssert.1.0.87.nupkg

WORKDIR /exercises-csharp

COPY src src
RUN ln -s /exercises-csharp/src /src && \
    mkdir -p /tmp/dotnet-cli /tmp/dotnet-script-cache && \
    dotnet-script /src/Warmup.csx > /dev/null

COPY . .
