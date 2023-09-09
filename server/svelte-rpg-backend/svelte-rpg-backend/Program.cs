using Microsoft.EntityFrameworkCore;
using svelte_rpg_backend.Context;

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