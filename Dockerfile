# Asegúrese de que el clúster de Service Fabric que implementa admita la imagen de contenedor que usa. Para obtener información sobre la compatibilidad de versiones de contenedor de Windows, consulte https://aka.ms/containerimagehelp.
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .
