using InternsAdaptationService.API.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var postgresDbConnection = configuration.GetConnectionString("PostgresDbConnection")!;


// Add Controllers.
builder.Services.AddControllers();

// Add DataLayer
builder.Services.InjectDataLayer(postgresDbConnection);

// Add InfrastructureLayer
builder.Services.InjectInfrastructureLayer();

// Add AuthOptions
builder.Services.InjectAuthOptions();


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
