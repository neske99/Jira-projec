
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Contracts;

public static class ProductInfrastructureServiceRegistration
{
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddProjectApplicationServices();
    services.AddScoped<IProjectRepository, IProjectRepository>();
    services.AddDbContext<ProjectContext>(options =>
        options.UseNpgsql(
            configuration.GetConnectionString("ProjectConnectionString")));

    // Register other infrastructure services here

    return services;
  }

}