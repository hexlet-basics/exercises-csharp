FROM hexletbasics/base-image:latest

ENV DOTNET_CLI_TELEMETRY_OPTOUT=1 \
    DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1 \
    DOTNET_NOLOGO=1 \
    DOTNET_MULTILEVEL_LOOKUP=0 \
    DOTNET_CLI_HOME=/tmp/dotnet-cli \
    DOTNET_SCRIPT_CACHE_LOCATION=/tmp/dotnet-script-cache \
    DOTNET_GCHeapHardLimit=10000000 \
    PATH=/opt/dotnet-tools:/exercises-csharp/bin:$PATH

RUN apt-get update && \
    apt-get install -yqq ca-certificates gnupg unzip wget && \
    wget -q https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    rm packages-microsoft-prod.deb && \
    apt-get update && \
    apt-get install -yqq dotnet-sdk-8.0 && \
    rm -rf /var/lib/apt/lists/*

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
