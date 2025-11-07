using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Project;

public class ProjectTypeConfiguration : IEntityTypeConfiguration<ProjectType>
{
  public void Configure(EntityTypeBuilder<ProjectType> builder)
  {
    builder.ToTable("ProjectType");
  }
}