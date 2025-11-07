using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TaskStatusConfiguration : IEntityTypeConfiguration<Project.Domain.Entities.Task.TaskStatus>
{

  public void Configure(EntityTypeBuilder<Project.Domain.Entities.Task.TaskStatus> builder)
  {
    builder.ToTable("TaskStatus");
  }
}