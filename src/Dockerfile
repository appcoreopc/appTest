# must run from src root
FROM cap-docker.coretexa.local/c3test/builder:latest AS builder

ARG C3ISRUNNINGONTEAMCITY=false

WORKDIR /repo
# Copies in stuff from the root of the repo i.e nuget and tools directory
COPY .roottmp/ .
# downloads the c3 task runner
RUN c3 --packagecheckonly

FROM builder AS srcbuild

ARG C3ISRUNNINGONTEAMCITY=false

SHELL [ "powershell.exe" ]

RUN write-host " Running under Team City: $($env:C3ISRUNNINGONTEAMCITY)"

COPY .srctmp/ src/

RUN dotnet restore src/C3PostTrade.Code.Analyzers.Net.sln

COPY . src/

RUN move-item src\.srctmp c:\.srctmp

WORKDIR /repo/src
RUN c3 dev build --teamcity=$env:C3ISRUNNINGONTEAMCITY

RUN c3 dev package --teamcity=$env:C3ISRUNNINGONTEAMCITY
