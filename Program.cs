using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using MyWebApi.Services;
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:5005");

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

//builder.Services.AddDbContext<AppContext>(options =>
//    options.UseInMemoryDatabase("UsersDb"));

builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseRouting();
app.MapControllers();
app.UseHttpsRedirection();



app.Run();

