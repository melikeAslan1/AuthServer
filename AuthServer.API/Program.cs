using AuthServer.Core.Configuration;
using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using SharedLibrary.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<CustomTokenOptions>(builder.Configuration.GetSection("TokenOption"));  //appsettings icindeki tokenoptionsı class a cevirmek istedim class'ini yazdim ve aradaki iletisim icin bu kodu yazdim.
builder.Services.Configure<Client>(builder.Configuration.GetSection("Clients"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
