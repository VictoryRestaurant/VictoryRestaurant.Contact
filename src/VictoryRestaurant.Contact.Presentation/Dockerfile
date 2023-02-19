FROM mcr.microsoft.com/dotnet/aspnet:7.0-bullseye-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim AS build
WORKDIR /src
COPY ["src/VictoryRestaurant.Contact.Presentation", "VictoryRestaurant.Contact.Presentation/"]
RUN dotnet restore "VictoryRestaurant.Contact.Presentation/VictoryRestaurant.Contact.Presentation.csproj"
COPY . .

WORKDIR "/src/VictoryRestaurant.Contact.Presentation"
RUN dotnet build "VictoryRestaurant.Contact.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VictoryRestaurant.Contact.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VictoryRestaurant.Contact.Presentation.dll"]