using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteHouseEasy.Models;

namespace TesteHouseEasy.Data.Map
{
    public class PhoneMap : IEntityTypeConfiguration<PhoneModel>
    {
        public void Configure(EntityTypeBuilder<PhoneModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            
        }
    }
}
