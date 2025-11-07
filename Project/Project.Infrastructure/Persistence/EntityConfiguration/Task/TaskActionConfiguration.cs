using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TaskActionConfiguration : IEntityTypeConfiguration<TaskAction>
{
  public void Configure(EntityTypeBuilder<TaskAction> builder)
  {
    builder.ToTable("TaskAction");
  }
}