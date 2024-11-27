using Ardalis.SharedKernel;
using ExpenseManagement.Core.ContributorAggregate;
using ExpenseManagement.UseCases.Contributors.Create;
using MediatR;
using System.Reflection;

namespace ExpenseManagement.Web.Configurations;

/// <summary>
/// 
/// </summary>
public static class MediatrConfigs
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="services"></param>
  /// <returns></returns>
  public static IServiceCollection AddMediatrConfigs(this IServiceCollection services)
  {
    var mediatRAssemblies = new[]
      {
        Assembly.GetAssembly(typeof(Contributor)), // Core
        Assembly.GetAssembly(typeof(CreateContributorCommand)) // UseCases
      };

    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!))
            .AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>))
            .AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();

    return services;
  }
}
