using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;
using Project.Domain.Entities.User;

namespace Project.Domain.Entities.Project;

public class ProjectActoinRoleConfiguration : IEntityTypeConfiguration<ProjectActoinRole>
{
  public void Configure(EntityTypeBuilder<ProjectActoinRole> builder)
  {
    builder.ToTable("ProjectActionRole");
    builder.HasIndex(par => par.Id);

    builder.HasOne<ProjectAction>().WithMany()
      .HasForeignKey(par => par.ProjectActionId);

    builder.HasOne<Role>().WithMany()
      .HasForeignKey(par => par.RoleId);
  }
}