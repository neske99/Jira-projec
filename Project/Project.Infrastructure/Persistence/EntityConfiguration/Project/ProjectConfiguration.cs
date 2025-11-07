using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

  public class ProjectConfiguration : IEntityTypeConfiguration<Project.Domain.Entities.Project.Project>
  {
    public void Configure(EntityTypeBuilder<Project.Domain.Entities.Project.Project> builder)
    {
      builder.ToTable("Project");
    }
  }