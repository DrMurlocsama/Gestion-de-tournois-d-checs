using GestionEchecs.Service;
using Microsoft.EntityFrameworkCore;
using TournoiEchec.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TournoiContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("local")));
builder.Services.AddScoped<JoueurService>();
builder.Services.AddScoped<TournoisService>();

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
