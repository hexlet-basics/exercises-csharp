FROM hexletbasics/base-image:latest

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

RUN wget https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    rm packages-microsoft-prod.deb
RUN apt-get update && apt-get install -y dotnet-sdk-6.0

WORKDIR /exercises-csharp
ENV PATH=/exercises-csharp/bin:$PATH

RUN dotnet tool install -g JetBrains.ReSharper.GlobalTools
RUN dotnet tool install -g dotnet-script --version 1.3.1

ENV PATH=/root/.dotnet/tools:$PATH

COPY src/ src/

RUN dotnet script src/Warmup.csx
RUN ln -s /exercises-csharp/src /src

COPY . .

RUN make test
