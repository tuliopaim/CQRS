using Microsoft.OpenApi.Models;
using MSBase.Auditoria.API.Consumers;
using MSBase.Auditoria.API.Domain;
using MSBase.Auditoria.API.Infrasctructure;
using MSBase.Core.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AuditoriaDbContext>();
builder.Services.AddScoped<IAuditoriaRepository, AuditoriaEntidadeRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AuditoriaEntidade.API", Version = "v1" });
});

builder.Services.RegistrarCore(new CoreSettings
{
    Configuration = builder.Configuration,
    TipoDaCamadaDeApplication = typeof(AuditoriaEntidade),
    TipoDoStartup = typeof(AuditoriaEntidade),
});

builder.Services.AddHostedService<AuditoriaConsumerBackgroundService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AuditoriaEntidade.API v1"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
