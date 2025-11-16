using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Project.Infrastructure.Persistence;

public class ProjectDesignTimeFactory : IDesignTimeDbContextFactory<ProjectContext>
{
  public ProjectContext CreateDbContext(string[] args)
  {

    var optionsBuilder = new DbContextOptionsBuilder<ProjectContext>();
    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ProjectDB;Username=admin;Password=admin1234");
    return new ProjectContext(optionsBuilder.Options);
  }
}