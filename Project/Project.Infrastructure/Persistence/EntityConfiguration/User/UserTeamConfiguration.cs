using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Entities.Common;
using Project.Domain.Entities.User;

public class UserTeamConfiguration : IEntityTypeConfiguration<UserTeam>
{
  public void Configure(EntityTypeBuilder<UserTeam> builder)
  {
    builder.ToTable("UserTeam");
    builder.HasIndex(ut => ut.Id);

    builder.HasOne<User>().WithMany()
      .HasForeignKey(ut => ut.UserId);

    builder.HasOne<Team>().WithMany()
      .HasForeignKey(ut => ut.TeamId);
  }
}