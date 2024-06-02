using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using System;
using MattiasHandel.Services;
using MattiasHandel.Extras;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
                        //.AllowCredentials()); // Adjust this based on your specific needs
});

builder.Services.AddScoped<IProduktService, ProduktService>();
builder.Services.AddScoped<IDBContext, AppDbContext>();

if (builder.Environment.IsDevelopment())
{
    var connectionString = builder.Configuration.GetConnectionString("LocalConnection");
}
else
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
}

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAll");

// Configure the HTTP request pipeline.

//http://localhost:5173/index.html
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
