FROM ghcr.io/ahdcreative/xivita-daladocker:latest@sha256:8f2b8edfd2639cc9b53c944161c8c58f50a30e3cdd8ab0ec81f052799d47b92c

# Optout of telemtry.
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1

# Create a non-root dev user.
RUN adduser --disabled-password --gecos "" dev

# Install required dependencies.
RUN apk add --update openssh

# Download the repository into /workspaces (overwrote if using a compliant tool).
WORKDIR /workspaces 
RUN git clone https://github.com/AHDCreative/ArtekGuide.git
