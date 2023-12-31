using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;
using svelte_rpg_backend.Models;
using svelte_rpg_backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB CONNECTION
string conString = builder.Configuration.GetConnectionString("SvelteRpgConnection");
ServerVersion version = ServerVersion.AutoDetect(conString);
builder.Services.AddDbContext<RpgContext>(opts => opts.UseMySql(conString, version));
builder.Services.AddTransient<UserService, UserService>();
builder.Services.AddTransient<HeroService, HeroService>();
builder.Services.AddTransient<SystemService, SystemService>();
builder.Services.AddTransient<MonsterService, MonsterService>();
builder.Services.AddTransient<GameLogicService, GameLogicService>();
builder.Services.AddTransient<AuthService, AuthService>();

// APP
var app = builder.Build();
app.UseCors(e => e.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader());

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
