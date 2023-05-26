using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Data.Map
{
    public class AddressMap : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Street).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Complement).HasMaxLength(255);
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.State).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(20);
        }
    }
}
