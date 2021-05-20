FROM hexletbasics/base-image:latest

RUN apt-get update && \
    apt-get install -y apt-transport-https
RUN curl -L https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb > packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb
RUN apt-get update && \
    apt-get install -y dotnet-sdk-5.0
RUN dotnet tool install --tool-path ~/bin JetBrains.ReSharper.GlobalTools

WORKDIR /exercises-csharp

COPY . .

