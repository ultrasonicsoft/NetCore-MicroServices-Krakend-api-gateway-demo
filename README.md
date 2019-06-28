# Building Micro services with .NET Core 2.2 + Krakend API gateway

## Introduction

.NET Core is open source framework for building REST API. Purpose of this repository is to demonstrate how to build Microservices in .Net Core (v2.2) and use Krakend API gateway.

## Installation

This repository has been built and tested on MacBook Pro hence installation steps are related to it.

* Download and Install [.Net Core framework](https://dotnet.microsoft.com/download)
* Download and Install [VS Code 2019 for Mac](https://visualstudio.microsoft.com/vs/mac/) or [VS Code](https://code.visualstudio.com/) based on your IDE choice.
* Download and install [Krakend API SDK](https://www.krakend.io/)

## Running projects

* Open krakend-api-gateway-demo.sln solution file in VS 2019
* Select "Multiple Projects" option in Debug configuration and Run application. Alternatively you can run projects via dotnet core CLI commands as well.
* Start Krakend API gateway by running command: `krakend run -c krakend.json` in solution directory.
* Hit `http://localhost:8080/users` url in browser or in POSTMAN and you should get list of all user. Similarly you can hit `http://localhost:8080/products` for products. Refer POSTMAN collection in repository for more endpoints.


## Development

* If you want to add new endpoint in your Web API project then make sure you add respective entry in `krakend.json` file and restart krakend server so that new changes can take place.