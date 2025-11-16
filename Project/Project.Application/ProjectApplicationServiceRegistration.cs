using Microsoft.Extensions.DependencyInjection;

public static class ProjectApplicationServiceRegistration
{
  public static IServiceCollection AddProjectApplicationServices(this IServiceCollection services)
  {
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
    return services;
  }

}