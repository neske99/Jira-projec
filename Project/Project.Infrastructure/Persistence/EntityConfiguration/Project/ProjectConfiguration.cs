using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Project;

  public class ProjectConfiguration : IEntityTypeConfiguration<Project.Domain.Entities.Project.Project>
  {
    public void Configure(EntityTypeBuilder<Project.Domain.Entities.Project.Project> builder)
    {
      builder.ToTable("Project");
      builder.HasIndex(p => p.Id);

      builder.HasOne(p=>p.ProjectType)
      .WithMany()
      .HasForeignKey(p => p.ProjectTypeId);

      builder.HasOne(p=>p.ProjectStatus)
      .WithMany()
      .HasForeignKey(p => p.ProjectStatusId);
    }
  }