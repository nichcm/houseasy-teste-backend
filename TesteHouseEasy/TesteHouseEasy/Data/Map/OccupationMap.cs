using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Data.Map
{
    public class OccupationMap : IEntityTypeConfiguration<OccupationModel>
    {
        public void Configure(EntityTypeBuilder<OccupationModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Position).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Department).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Responsibilities).HasMaxLength(255);
            builder.Property(x => x.EmploymentStatus).HasMaxLength(20);
            builder.Property(x => x.Salary).IsRequired().HasMaxLength(20);

            builder.HasMany<UserModel>()
                .WithOne(x => x.OccupationModel)
                .HasForeignKey(x => x.OccupationModelId);

        }
    }
}
