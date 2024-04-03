using Microsoft.EntityFrameworkCore;
using VillaAPI.Models;

namespace VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Villa> villas = new List<Villa>
            {
                new Villa
                {
                    Id = 1,
                    Name = "Luxury Villa",
                    Details = "Spacious luxury villa with stunning ocean views",
                    Rate = 5.0,
                    Sqft = 3000,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/images/villa1.jpg",
                    Amenity = "Private pool, Wi-Fi, Air conditioning",
                    CreatedDate = DateTime.Now.AddDays(-30),
                    UpdatedDate = DateTime.Now.AddDays(-5)
                },
                new Villa
                {
                    Id = 2,
                    Name = "Beachfront Villa",
                    Details = "Beautiful beachfront villa with direct access to the beach",
                    Rate = 4.0,
                    Sqft = 2500,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/images/villa2.jpg",
                    Amenity = "Garden, BBQ, Beach access",
                    CreatedDate = DateTime.Now.AddDays(-25),
                    UpdatedDate = DateTime.Now.AddDays(-3)
                },
                new Villa
                {
                    Id = 3,
                    Name = "Mountain Retreat",
                    Details = "Cozy villa nestled in the mountains with scenic views",
                    Rate = 3.0,
                    Sqft = 2000,
                    Occupancy = 4,
                    ImageUrl = "https://example.com/images/villa3.jpg",
                    Amenity = "Fireplace, Hiking trails",
                    CreatedDate = DateTime.Now.AddDays(-20),
                    UpdatedDate = DateTime.Now.AddDays(-2)
                },
                new Villa
                {
                    Id = 4,
                    Name = "Family Villa",
                    Details = "Family-friendly villa with a large backyard and play area",
                    Rate = 3.5,
                    Sqft = 2200,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/images/villa4.jpg",
                    Amenity = "Children's playground, Game room",
                    CreatedDate = DateTime.Now.AddDays(-15),
                    UpdatedDate = DateTime.Now.AddDays(-1)
                },
                new Villa
                {
                    Id = 5,
                    Name = "Modern Villa",
                    Details = "Stylish and modern villa with contemporary design",
                    Rate = 4.5,
                    Sqft = 2800,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/images/villa5.jpg",
                    Amenity = "Swimming pool, Gym, Smart home features",
                    CreatedDate = DateTime.Now.AddDays(-10),
                    UpdatedDate = DateTime.Now
                }
            };
            modelBuilder.Entity<Villa>()
                .HasData(villas);
            
        }
    }
}
