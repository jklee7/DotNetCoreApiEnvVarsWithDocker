.NET core project demonstrating the use of Environment variables in Docker.

Environment variables are preferred over appsettings.json transforms, as this way we don't have any secrets lying written in plaintext within the container.

Further ideas: 
- Keep all secrets in Keyvault; The only environment variables we need to provide then are the Keyvault URI and credentials.
- Best way to handle HTTPS in Docker?

References:
- [Using Docker env vars in .NET Core][1]


[1]: https://cmelendeztech.com/posts/2017/02/using-docker-env-vars-in-dotnet-core.html