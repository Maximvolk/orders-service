FROM mcr.microsoft.com/dotnet/sdk:5.0
COPY . /app
WORKDIR /app/OrdersService.Web
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 5000
RUN chmod +x ../entrypoint.sh
CMD /bin/bash ../entrypoint.sh