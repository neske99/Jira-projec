using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;
using Project.Domain.Entities.User;

public class UserConfiguration:IEntityTypeConfiguration<User>
{

  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.ToTable("User");
    builder.HasIndex(u => u.Id);
  }
}