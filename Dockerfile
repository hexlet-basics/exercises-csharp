FROM hexletbasics/base-image:latest

RUN apt-get update && apt-get install -yq mono-devel

ARG SCRIPCS_VERSION=0.17.1

RUN wget -q https://github.com/scriptcs/scriptcs/archive/refs/tags/v${SCRIPCS_VERSION}.tar.gz \
    && tar -xzf v${SCRIPCS_VERSION}.tar.gz \
    && rm v${SCRIPCS_VERSION}.tar.gz

RUN cd scriptcs-${SCRIPCS_VERSION} && ./build.sh
ENV PATH=/scriptcs-${SCRIPCS_VERSION}/artifacts/Release/bin:$PATH

RUN scriptcs -install PowerAssert 1.0.87

WORKDIR /exercises-csharp
ENV PATH=/exercises-csharp/bin:$PATH

COPY src src
RUN ln -s /exercises-csharp/src /src

COPY . .
