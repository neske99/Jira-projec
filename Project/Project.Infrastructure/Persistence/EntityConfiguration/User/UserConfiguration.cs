using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;

public class UserConfiguration:IEntityTypeConfiguration<User>
{

  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.ToTable("User");
    builder.HasIndex(u => u.Id);
  }
}