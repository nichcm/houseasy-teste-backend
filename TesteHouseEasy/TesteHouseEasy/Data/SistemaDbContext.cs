using Microsoft.EntityFrameworkCore;
using System.Net;
using TesteHouseEasy.Data.Map;
using TesteHouseEasy.Models;

namespace apiFundadores.Data
{
    public class SistemaDbContext : DbContext
    {

        public SistemaDbContext(DbContextOptions<SistemaDbContext> options):
            base(options)
        { 
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<OccupationModel> Occupations { get; set; }
        public DbSet<PhoneModel> Phones { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OccupationMap());
            modelBuilder.ApplyConfiguration(new PhoneMap());
            modelBuilder.ApplyConfiguration(new AddressMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
