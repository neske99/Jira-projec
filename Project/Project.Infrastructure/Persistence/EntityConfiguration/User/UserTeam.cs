using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;

public class UserTeamConfiguration : IEntityTypeConfiguration<UserTeam>
{
  public void Configure(EntityTypeBuilder<UserTeam> builder)
  {
    builder.ToTable("UserTeam");
  }
}