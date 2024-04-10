using LAtelier.CutestCatApi.Api.Common.Middlewares;
using LAtelier.CutestCatApi.Domain.Interfaces;
using LAtelier.CutestCatApi.Domain.Services;
using LAtelier.CutestCatApi.Infrastructure.Repositories;
using LAtelier.CutestCatApi.Infrastructure.SQLiteDb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("WebApiDatabase")));

// D.I 
builder.Services.AddScoped<DbContext, DataContext>();
builder.Services.AddScoped<ICatsManagerService, CatsManagerService>();
builder.Services.AddScoped<IVotesManagerService, VotesManagerService>();
builder.Services.AddScoped<ICatsRepository, CatsRepository>();
builder.Services.AddScoped<IVotesRepository, VotesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Global server error handle middleware
app.UseServerErrorHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
