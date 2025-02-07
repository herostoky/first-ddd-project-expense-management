namespace ExpenseManagement.Api.Configurations;

public static class ControllerConfigurations
{
  public static IServiceCollection AddControllerConfigurations(this IServiceCollection services)
  {
    // Add services to the container.
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    services.AddOpenApi();
    services.AddControllers();

    return services;
  }
}
