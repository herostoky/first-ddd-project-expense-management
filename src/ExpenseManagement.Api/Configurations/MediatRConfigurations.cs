using System.Reflection;
using Ardalis.SharedKernel;
using ExpenseManagement.Core.UserAggregate;
using ExpenseManagement.UseCases.Users.SignIn;
using MediatR;

namespace ExpenseManagement.Api.Configurations;

public static class MediatRConfigurations
{
  public static IServiceCollection AddMediatrConfigurations(this IServiceCollection services)
  {
    var mediatRAssemblies = new[]
    {
      Assembly.GetAssembly(typeof(User)), // Core
      Assembly.GetAssembly(typeof(UserSignInCommand)) // UseCases
    };

    services.AddMediatR(c => c.RegisterServicesFromAssemblies(mediatRAssemblies!))
      .AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>))
      .AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();

    return services;
  }
}
