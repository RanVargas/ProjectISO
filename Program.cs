using Microsoft.EntityFrameworkCore;
using ProjectISO.Data;
using ProjectISO.Interfaces;
using ProjectISO.Services;
using SoapCore;
using static SoapCore.DocumentationWriter.SoapDefinition;

/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();*/


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//builder.Services.AddSingleton<IActivoService, ActivoService>();
//builder.Services.AddSingleton<IEmpleadoService, EmpleadoService>();
//builder.Services.AddSingleton<IDepartamentoService, DepartamentoService>();
//builder.services.AddScoped<ISoapService, SoapService>();
builder.Services.AddScoped<IDepartamentoService,  DepartamentoService>();
builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();
builder.Services.AddScoped<IActivoService, ActivoService>();


builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();
// Configure the HTTP request pipeline.
//app.UseSoapEndpoint<IAuthorService>("/Service.asmx", new SoapEncoderOptions());
app.UseSoapEndpoint<IActivoService>("/Activo.asmx", new SoapEncoderOptions());
app.UseSoapEndpoint<IEmpleadoService>("/Empleado.asmx", new SoapEncoderOptions());
app.UseSoapEndpoint<IDepartamentoService>("/Departamento.asmx", new SoapEncoderOptions());

//app.UseAuthorization();
app.MapControllers();
app.Run();
