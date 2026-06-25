FROM ubuntu:24.04

ENV DEBIAN_FRONTEND=noninteractive
ENV DOTNET_VERSION=10.0

# Системные зависимости нужные Unity и .NET
RUN apt-get update && apt-get install -y \
    curl wget git ca-certificates \
    libglu1-mesa libxrender1 libxi6 \
    libxcursor1 libxrandr2 libxinerama1 \
    libasound2 libgbm1 xvfb \
    && rm -rf /var/lib/apt/lists/*

# .NET SDK 10
RUN curl -fsSL https://dot.net/v1/dotnet-install.sh | bash -s -- \
    --version 10.0.5 --install-dir /usr/local/dotnet
ENV PATH="$PATH:/usr/local/dotnet"
ENV DOTNET_ROOT="/usr/local/dotnet"

# Unity Hub CLI
RUN wget -qO /usr/local/bin/unityhub \
    https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.AppImage \
    && chmod +x /usr/local/bin/unityhub

WORKDIR /workspace

CMD ["/bin/bash"]
