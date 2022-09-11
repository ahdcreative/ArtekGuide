FROM ghcr.io/ahdcreative/xivita-daladocker:latest@sha256:fa99c0d950666869be2846b46a3f8f98f8b410432382d1d5ef03fced6c93ab61

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
