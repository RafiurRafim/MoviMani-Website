using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviMani.Models;

namespace MoviMani.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ProductImage>ProductImages { get; set; }

		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                    );

            modelBuilder.Entity<Company>().HasData(
               new Company
               {
                   Id = 1,
                   Name = "Tech Solution",
                   StreetAddress = "123 Tech St",
                   City = "Tech City",
                   PostalCode = "12121",
                   State = "IL",
                   PhoneNumber = "6669990000"
               },
               new Company
               {
                   Id = 2,
                   Name = "Vivid Books",
                   StreetAddress = "999 Vid St",
                   City = "Vid City",
                   PostalCode = "66666",
                   State = "IL",
                   PhoneNumber = "7779990000"
               },
               new Company
               {
                   Id = 3,
                   Name = "Readers Club",
                   StreetAddress = "999 Main St",
                   City = "Lala land",
                   PostalCode = "99999",
                   State = "NY",
                   PhoneNumber = "1113335555"
               }
               );

            modelBuilder.Entity<Product>().HasData(
                         new Product
                         {
                             Id = 1,
                             Title = "Fortune of Time",
                             Director = "Billy Spark",
                             Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh uiverra ipsum sit amet tincidunt. ",
                             ISAN = "SWD9999001",
                             ListPrice = 99,
                             Price = 90,
                             Price5 = 85,
                             Price10 = 80,
                             CategoryId = 1,
                             //ImageUrl=""
                         },
                         new Product
                         {
                             Id = 2,
                             Title = "Dark Skies",
                             Director = "Nancy Hoover",
                             Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisnc malesuada viverra ipsum sit amet tincidunt. ",
                             ISAN = "CAW777777701",
                             ListPrice = 40,
                             Price = 30,
                             Price5 = 25,
                             Price10 = 20,
                             CategoryId = 1,
                            // ImageUrl = ""
                         },
                         new Product
                         {
                             Id = 3,
                             Title = "Vanish in the Sunset",
                             Director = "Julian Button",
                             Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut u viverra ipsum sit amet tincidunt. ",
                             ISAN = "RITO5555501",
                             ListPrice = 55,
                             Price = 50,
                             Price5 = 40,
                             Price10 = 35,
                             CategoryId = 1,
                            // ImageUrl = ""
                         },
                         new Product
                         {
                             Id = 4,
                             Title = "Cotton Candy",
                             Director = "Abby Muscles",
                             Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultrrra ipsum sit amet tincidunt. ",
                             ISAN = "WS3333333301",
                             ListPrice = 70,
                             Price = 65,
                             Price5 = 60,
                             Price10 = 55,
                             CategoryId = 2,
                             //ImageUrl = ""
                         },
                         new Product
                         {
                             Id = 5,
                             Title = "Rock in the Ocean",
                             Director = "Ron Parker",
                             Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut uluada viverra ipsum sit amet tincidunt. ",
                             ISAN = "SOTJ1111111101",
                             ListPrice = 30,
                             Price = 27,
                             Price5 = 25,
                             Price10 = 20,
                             CategoryId = 2,
                           //  ImageUrl = ""
                         },
                         new Product
                         {
                             Id = 6,
                             Title = "Leaves and Wonders",
                             Director = "Laura Phantom",
                             Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultviverra ipsum sit amet tincidunt. ",
                             ISAN = "FOT000000001",
                             ListPrice = 25,
                             Price = 23,
                             Price5 = 22,
                             Price10 = 20,
                             CategoryId = 3,
                            // ImageUrl = ""
                         }
                         );
        }
    }
}