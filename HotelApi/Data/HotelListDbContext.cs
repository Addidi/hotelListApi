using Microsoft.EntityFrameworkCore;

namespace HotelApi.Data
{
    public class HotelListDbContext : DbContext
    {
        public HotelListDbContext(DbContextOptions<HotelListDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Haiti", ShortName = "HT" },
                new Country{ Id = 2, Name = "United States Of America", ShortName = "USA" },
                new Country { Id = 3, Name = "Jamaica", ShortName = "JM" },
                new Country { Id = 4, Name = "Bahamas", ShortName = "BS" },
                new Country { Id = 5 , Name = "Canada", ShortName= "CA" }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Address= "Port-au-Prince", CountryId = 1, Name = "Marriot Hotel", Rating = 3.9 },
                new Hotel { Id = 2, Address = "Machassussets", CountryId = 2, Name = "Red Roof", Rating = 4.1 },
                new Hotel { Id = 3, Address = "Jamaica City", CountryId = 3, Name = "Bob Marley Suites", Rating = 4.3 },
                new Hotel { Id = 4, Address = "AnkaraVille", CountryId = 4, Name = "Malibu Nice Hotel", Rating = 4.2 },
                new Hotel { Id = 5, Address = "Chateau Brunelle", CountryId = 5, Name = "La bellevue Hotel", Rating = 4.5 }
                );

        }
    }
}
