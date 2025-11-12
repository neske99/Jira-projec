using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Project;
public class ProjectActionConfiguration:IEntityTypeConfiguration<ProjectAction>
{

  public void Configure(EntityTypeBuilder<ProjectAction> builder)
  {
    builder.ToTable("ProjectAction");
    builder.HasIndex(pa => pa.Id);

    builder.HasOne<ProjectType>().WithMany()
      .HasForeignKey(pa => pa.ProjectTypeId);

    builder.HasOne<ProjectStatus>().WithMany()
      .HasForeignKey(pa => pa.ProjectStatusIdFrom);

    builder.HasOne<ProjectStatus>().WithMany()
      .HasForeignKey(pa => pa.ProjectStatusIdTo);
  }
}