using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Task;

public class TaskTypeConfiguration : IEntityTypeConfiguration<TaskType>
{


  public void Configure(EntityTypeBuilder<TaskType> builder)
  {
    builder.ToTable("TaskType");
  }
}