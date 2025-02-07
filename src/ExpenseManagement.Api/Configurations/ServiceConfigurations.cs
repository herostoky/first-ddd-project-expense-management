using ExpenseManagement.Core.Interfaces;
using ExpenseManagement.Infrastructure;
using ExpenseManagement.Infrastructure.Email;

namespace ExpenseManagement.Api.Configurations;

/// <summary>
/// Class to register all required services in the API Project.
/// </summary>
public static class ServiceConfigurations
{
  public static IServiceCollection AddServiceConfigurations(this IServiceCollection services, WebApplicationBuilder builder, ILogger logger)
  {
    // Controllers
    services.AddControllerConfigurations();
    // MediatR
    services.AddMediatrConfigurations();
    // Infrastructure
    services.AddInfrastructureServices(builder.Configuration, logger);
    // Required services
    services.AddScoped<IEmailSender, MimeKitEmailSender>();

    return services;
  }


}
