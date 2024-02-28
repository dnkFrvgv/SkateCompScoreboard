using API.Extentions;
using MediatR;
using SkateCompScoreboard.Application.Competitions.Commands;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors();

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSQLConnection(builder.Configuration);

builder.Services.AddMediatR(typeof(ListCommand.Handler));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
