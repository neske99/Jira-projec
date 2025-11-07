using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Task;

public class TaskActionRoleConfiguration : IEntityTypeConfiguration<TaskActionRole>
{

  public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TaskActionRole> builder)
  {
    builder.ToTable("TaskActionRole");
  }
}