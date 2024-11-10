using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using VibeChat.Api.Hubs;
using VibeChat.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<ChatService>();
builder.Services.AddSignalR();
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:4200"));

app.UseHttpsRedirection();
app.MapControllers();
app.MapHub<ChatHub>("/hubs/chat");
app.Run();