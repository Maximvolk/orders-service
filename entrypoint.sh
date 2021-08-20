#!/bin/bash

dotnet dev-certs https -ep /.aspnet/https/aspnetapp.pfx -p password
dotnet run