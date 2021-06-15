using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
await using var app = builder.Build();

app.MapGet("/", (Func<GreetingDto>)(() => new GreetingDto("Hello, world!")));

await app.RunAsync();

record GreetingDto(string Greeting);
