using Serilog;

namespace ExpenseManagement.Web.Configurations;

/// <summary>
/// 
/// </summary>
public static class LoggerConfigs
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="builder"></param>
  /// <returns></returns>
  public static WebApplicationBuilder AddLoggerConfigs(this WebApplicationBuilder builder)
  {

    builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));

    return builder;
  }
}
