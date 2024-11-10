using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using VibeChat.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<ChatService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();