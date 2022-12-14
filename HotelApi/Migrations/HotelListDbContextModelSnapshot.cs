// <auto-generated />
using HotelApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelApi.Migrations
{
    [DbContext(typeof(HotelListDbContext))]
    partial class HotelListDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelApi.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Haiti",
                            ShortName = "HT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "United States Of America",
                            ShortName = "USA"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jamaica",
                            ShortName = "JM"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bahamas",
                            ShortName = "BS"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Canada",
                            ShortName = "CA"
                        });
                });

            modelBuilder.Entity("HotelApi.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Port-au-Prince",
                            CountryId = 1,
                            Name = "Marriot Hotel",
                            Rating = 3.8999999999999999
                        },
                        new
                        {
                            Id = 2,
                            Address = "Machassussets",
                            CountryId = 2,
                            Name = "Red Roof",
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            Id = 3,
                            Address = "Jamaica City",
                            CountryId = 3,
                            Name = "Bob Marley Suites",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 4,
                            Address = "AnkaraVille",
                            CountryId = 4,
                            Name = "Malibu Nice Hotel",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 5,
                            Address = "Chateau Brunelle",
                            CountryId = 5,
                            Name = "La bellevue Hotel",
                            Rating = 4.5
                        });
                });

            modelBuilder.Entity("HotelApi.Data.Hotel", b =>
                {
                    b.HasOne("HotelApi.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelApi.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
