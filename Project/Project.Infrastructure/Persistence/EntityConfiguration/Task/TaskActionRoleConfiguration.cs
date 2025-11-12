using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Task;

public class TaskActionRoleConfiguration : IEntityTypeConfiguration<TaskActionRole>
{

  public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TaskActionRole> builder)
  {
    builder.ToTable("TaskActionRole");
    builder.HasIndex(tar => tar.Id);

    builder.HasOne<TaskAction>().WithMany()
      .HasForeignKey(tar => tar.TaskActionId);

    builder.HasOne<Project.Domain.Entities.User.Role>().WithMany()
      .HasForeignKey(tar => tar.RoleId);
  }
}