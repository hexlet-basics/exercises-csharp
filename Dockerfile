FROM hexletbasics/base-image:latest

RUN apt-get update && \
    apt-get install -yqq ca-certificates gnupg wget && \
    rm -rf /var/lib/apt/lists/* && \
    wget -qO - https://download.mono-project.com/repo/xamarin.gpg | gpg --dearmor -o /usr/share/keyrings/mono-official-archive-keyring.gpg && \
    echo "deb [signed-by=/usr/share/keyrings/mono-official-archive-keyring.gpg] https://download.mono-project.com/repo/ubuntu stable-focal main" | tee /etc/apt/sources.list.d/mono-official-stable.list && \
    apt-get update && \
    apt-get install -yqq mono-devel && \
    rm -rf /var/lib/apt/lists/*


ENV SCRIPCS_VERSION=0.17.1
RUN wget -q https://github.com/scriptcs/scriptcs/archive/refs/tags/v${SCRIPCS_VERSION}.tar.gz && \
    tar -xzf v${SCRIPCS_VERSION}.tar.gz && \
    rm v${SCRIPCS_VERSION}.tar.gz && \
    cd scriptcs-${SCRIPCS_VERSION} && ./build.sh

ENV PATH=/scriptcs-${SCRIPCS_VERSION}/artifacts/Release/bin:$PATH

RUN scriptcs -install PowerAssert 1.0.87

WORKDIR /exercises-csharp
ENV PATH=/exercises-csharp/bin:$PATH

COPY src src
RUN ln -s /exercises-csharp/src /src

COPY . .
