using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Project;
using Project.Domain.Entities.User;

public class ProjectTeamConfiguration : IEntityTypeConfiguration<ProjectTeam>
{
  public void Configure(EntityTypeBuilder<ProjectTeam> builder)
  {
    builder.ToTable("ProjectTeam");
    builder.HasIndex(pt => pt.Id);

    builder.HasOne<Project.Domain.Entities.Project.Project>()
      .WithMany()
      .HasForeignKey(pt => pt.ProjectId);

    builder.HasOne<Team>()
      .WithMany()
      .HasForeignKey(pt => pt.TeamsId);
  }
}