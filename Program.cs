using Microsoft.EntityFrameworkCore;
using Balanced_Soccer_Team_Generator.Data;
using Balanced_Soccer_Team_Generator.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SoccerDb")));

// Team generator service
builder.Services.AddScoped<ITeamGeneratorService, TeamGeneratorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Teams}/{action=SelectPlayers}/{id?}");

app.Run();
