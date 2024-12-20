using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  const string apiName = "WeatherForecast API V1";
  app.MapOpenApi(); // /openapi/v1.json
  app.UseSwaggerUI(options => options.SwaggerEndpoint(
    url: "/openapi/v1.json",
    name: apiName)); // /swagger/index.html
  app.MapScalarApiReference(options =>
      options
        .WithTitle(apiName)
        .WithTheme(ScalarTheme.Saturn)
        .WithDefaultHttpClient(ScalarTarget.JavaScript, ScalarClient.HttpClient))
    .WithName(apiName); // /scalar/v1
}

app.UseHttpsRedirection();

app.Run();
