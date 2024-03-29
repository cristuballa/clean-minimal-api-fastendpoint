﻿global using FastEndpoints;
global using FastEndpoints.Swagger;
global using Microsoft.AspNetCore.Authorization;
global using FluentValidation;
global using  MinimalApi.Endpoints;

var builder= WebApplication.CreateBuilder(args);
    builder.Services.AddFastEndpoints();
    builder.Services.AddSwaggerDoc();

var app=  builder.Build();
    app.UseFastEndpoints();
    app.UseOpenApi();
    app.UseSwaggerUi3(x=>x.ConfigureDefaults());

    app.Run();


    