using InternsAdaptationService.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var postgresDbConnection = configuration.GetConnectionString("PostgresDbConnection")!;


// Add Controllers.
builder.Services.AddControllers();

// Add Context
builder.Services.InjectDbContext(postgresDbConnection);

// Add Services
builder.Services.InjectServices();

// Add Managers
builder.Services.InjectManagers();

// Add AuthOptions
builder.Services.InjectAuthOptions();

// Add Handlers
builder.Services.InjectHandlers();

// Add Mappers
builder.Services.InjectMappers();

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

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
