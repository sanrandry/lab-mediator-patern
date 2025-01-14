using LabMediatorLibrary;
using LabMediatorLibrary.Domain.Interfaces.Repository;
using LabMediatorLibrary.Infrastructure.LocalDataAcess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDataAcessRepository, LocalDataAcess>();
builder.Services.AddMediatR((config) => config.RegisterServicesFromAssembly(typeof(DemoLibraryMediatorEntryPoint).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
