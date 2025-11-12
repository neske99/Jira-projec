using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;
namespace Project.Domain.Entities.Project;

public class ProjectStatusConfiguration:IEntityTypeConfiguration<ProjectStatus>
{

  public void Configure(EntityTypeBuilder<ProjectStatus> builder)
  {
    builder.ToTable("ProjectStatus");
    builder.HasIndex(ps => ps.Id);

    builder.HasOne<ProjectType>().WithMany()
      .HasForeignKey(ps => ps.ProjecTypeId);
  }
}