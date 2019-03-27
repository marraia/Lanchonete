FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY src/Services/Lanchonete.API/Lanchonete.API.csproj src/Services/Lanchonete.API/
RUN dotnet restore src/Services/Lanchonete.API/Lanchonete.API.csproj
COPY . .
WORKDIR /src/src/Services/Lanchonete.API
RUN dotnet build Lanchonete.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Lanchonete.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Lanchonete.API.dll"]
