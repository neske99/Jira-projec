using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TaskConfiguration : IEntityTypeConfiguration<Project.Domain.Entities.Task.Task>
{
  public void Configure(EntityTypeBuilder<Project.Domain.Entities.Task.Task> builder)
  {
    builder.ToTable("Task");

  }
}