using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;

public class UserRoleConfiguration:IEntityTypeConfiguration<UserRole>
{

  public void Configure(EntityTypeBuilder<UserRole> builder)
  {
    builder.ToTable("UserRole");
  }
}