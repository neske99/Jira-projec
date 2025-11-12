using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TaskActionConfiguration : IEntityTypeConfiguration<TaskAction>
{
  public void Configure(EntityTypeBuilder<TaskAction> builder)
  {
    builder.ToTable("TaskAction");
    builder.HasIndex(ta => ta.Id);

    builder.HasOne<Project.Domain.Entities.Task.TaskStatus>().WithMany()
      .HasForeignKey(ta => ta.TaskStatusIdFrom);

    builder.HasOne<Project.Domain.Entities.Task.TaskStatus>().WithMany()
      .HasForeignKey(ta => ta.TaskStatusIdTo);

    builder.HasOne<Project.Domain.Entities.Task.TaskType>().WithMany()
      .HasForeignKey(ta => ta.TaskTypeId);

  }
}