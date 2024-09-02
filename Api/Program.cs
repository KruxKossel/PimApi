using Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PlantechContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("Api")));


// Injeção de dependência para repositórios
// builder.Services.AddScoped<IAgricultorRepository, AgricultorRepository>();
// builder.Services.AddScoped<ICompradorRepository, CompradorRepository>();
// builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();
// builder.Services.AddScoped<IAdministradorRepository, AdministradorRepository>();
// builder.Services.AddScoped<IRelatorioRepository, RelatorioRepository>();
// builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
// builder.Services.AddScoped<IInsumoRepository, InsumoRepository>();
// builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
// builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
// builder.Services.AddScoped<ICompraRepository, CompraRepository>();
// builder.Services.AddScoped<IVendaRepository, VendaRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
