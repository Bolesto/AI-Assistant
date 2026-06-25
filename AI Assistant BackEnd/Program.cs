using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline
    app.MapOpenApi();
app.MapScalarApiReference();


app.MapGet("/helloword", () => "hello World");
app.MapPost("/helloword 22", () => "hello World 22");



app.UseHttpsRedirection();

app.Run();

