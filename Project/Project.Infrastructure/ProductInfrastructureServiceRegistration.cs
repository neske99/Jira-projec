
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Contracts;
using Project.Infrastructure.Persistence;
using Project.Infrastructure.Repositories;

public static class ProductInfrastructureServiceRegistration
{
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddProjectApplicationServices();
    services.AddScoped<IProjectRepository, ProductRepository>();
    services.AddDbContext<ProjectContext>(options =>
        options.UseNpgsql(
            configuration.GetConnectionString("ProjectConnectionString")));

    // Register other infrastructure services here

    return services;
  }

}