using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(20);
            builder.Property(x => x.OccupationModelId);

            builder.HasMany<PhoneModel>()
                .WithOne(x => x.UserModel)
                .HasForeignKey(x => x.UserModelId);

            builder.HasMany<AddressModel>()
                .WithOne(x => x.UserModel)
                .HasForeignKey(x => x.UserModelId);
        }
    }
}
