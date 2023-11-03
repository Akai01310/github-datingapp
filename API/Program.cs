using System.Net.WebSockets;
using System.Text;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("https://127.0.0.1:5001");

var _config = builder.Configuration.GetSection("datingapp.db");
var ConnectionString = _config["ConnectionString"];

// Add services to the container.
var services = builder.Services;

services.AddApplicationServices(_config);
services.AddControllers();
services.AddCors();
services.AddIdentityServices(_config);
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

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

internal class _config
{
    internal static string GetConnectionString(string v)
    {
        throw new NotImplementedException();
    }
}