FROM microsoft/dotnet
WORKDIR /app
COPY ./dist ./
EXPOSE 80 443
ENTRYPOINT ["dotnet", "DotnetCoreApiEnvironmentVars.dll"]