FROM microsoft/dotnet:1.1.2-runtime

WORKDIR /app

EXPOSE 80/tcp

COPY bin/Debug/netcoreapp1.1/publish /app

ENTRYPOINT ["dotnet", "HouseDemo.dll","--server.urls","http://*:80"]

