using AeC_Teste.API.Interfaces.Services;
using AeC_Teste.API.Services;
using AeC_Teste.API.Utils;
using AeC_Teste.Business.Interfaces.Repository;
using AeC_Teste.Data.Data;
using AeC_Teste.Data.Repository;
using Microsoft.EntityFrameworkCore;
using static AeC_Teste.API.Utils.LogHelper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
               .AddJsonFile("appsettings.json", true, true)
               .AddJsonFile($"appsettings.{builder.Environment}.json", true, true)
.AddEnvironmentVariables();

builder.Services.Configure<AppSettingsConfig>(builder.Configuration);

builder.Services.AddDbContext<AecDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoBancoDados")));

// registrando as dependências

// Services
builder.Services.AddHttpClient<ICidadeService, CidadeService>();
builder.Services.AddHttpClient<IClimaCidadeService, ClimaCidadeService>();
builder.Services.AddHttpClient<IClimaAeroportoService, ClimaAeroportoService>();
builder.Services.AddSingleton<ILogHelper, LogHelper>(x => new LogHelper(x.GetRequiredService<ILogger<LogHelper>>()));

// Repository
builder.Services.AddScoped<ILogErroRepository, LogErroRepository>();
builder.Services.AddScoped<IPrevisaoTempoAeroportoRepository, PrevisaoTempoAeroportoRepository>();
builder.Services.AddScoped<IPrevisaoTempoCidadeRepository, PrevisaoTempoCidadeRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();
app.UseRouting();
app.UseAuthorization();


app.Run();
