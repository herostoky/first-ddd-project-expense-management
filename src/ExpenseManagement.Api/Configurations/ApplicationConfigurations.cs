using Scalar.AspNetCore;

namespace ExpenseManagement.Api.Configurations;

public static class ApplicationConfigurations
{
  public static void Configure(this WebApplication application)
  {
    // Map Controllers
    application.MapControllers();

    // Add API Docs
    if (application.Environment.IsDevelopment())
    {
      const string apiName = "WeatherForecast API V1";
      application.MapOpenApi(); // /openapi/v1.json
      application.UseSwaggerUI(options => options.SwaggerEndpoint(
        url: "/openapi/v1.json",
        name: apiName)); // /swagger/index.html
      application.MapScalarApiReference(options =>
          options
            .WithTitle(apiName)
            .WithTheme(ScalarTheme.Saturn)
            .WithDefaultHttpClient(ScalarTarget.JavaScript, ScalarClient.HttpClient))
        .WithName(apiName); // /scalar/v1
    }

    // Use Https Redirection
    application.UseHttpsRedirection();
  }
}
