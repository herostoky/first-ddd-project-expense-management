using ExpenseManagement.Core.Interfaces;
using ExpenseManagement.Infrastructure;
using ExpenseManagement.Infrastructure.Email;

namespace ExpenseManagement.Web.Configurations;

/// <summary>
/// 
/// </summary>
public static class ServiceConfigs
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="services"></param>
  /// <param name="logger"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  public static IServiceCollection AddServiceConfigs(this IServiceCollection services, Microsoft.Extensions.Logging.ILogger logger, WebApplicationBuilder builder)
  {
    services.AddInfrastructureServices(builder.Configuration, logger)
            .AddMediatrConfigs();


    if (builder.Environment.IsDevelopment())
    {
      // Use a local test email server
      // See: https://ardalis.com/configuring-a-local-test-email-server/
      services.AddScoped<IEmailSender, MimeKitEmailSender>();

      // Otherwise use this:
      //builder.Services.AddScoped<IEmailSender, FakeEmailSender>();

    }
    else
    {
      services.AddScoped<IEmailSender, MimeKitEmailSender>();
    }

    logger.LogInformation("{Project} services registered", "Mediatr and Email Sender");

    return services;
  }


}
