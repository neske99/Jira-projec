using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Project;

public class ProjectActoinRoleConfiguration : IEntityTypeConfiguration<ProjectActoinRole>
{
  public void Configure(EntityTypeBuilder<ProjectActoinRole> builder)
  {
    builder.ToTable("ProjectActionRole");
  }
}