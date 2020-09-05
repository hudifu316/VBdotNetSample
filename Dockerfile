FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["VBdotNetHW.vbproj", "./"]
RUN dotnet restore "./VBdotNetHW.vbproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "VBdotNetHW.vbproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VBdotNetHW.vbproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VBdotNetHW.dll"]
