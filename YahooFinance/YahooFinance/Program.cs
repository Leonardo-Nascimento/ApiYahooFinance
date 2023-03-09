using Infra.Context;
using Infra.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using YahooFinance.Domain.Interfaces.Repository;
using YahooFinance.Domain.Interfaces.Services;
using YahooFinance.Domain.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<YahooFinanceDbContext>(options =>
              options.UseSqlServer(
                  builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IStockExchangeService, StockExchangeService>();
builder.Services.AddScoped<IAtivoRepository, AtivoRepository>();
builder.Services.AddScoped<IAssetVariationRepository, AssetVariationRepository>();



builder.Services.AddHttpContextAccessor();
builder.Services.AddMvc().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

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
