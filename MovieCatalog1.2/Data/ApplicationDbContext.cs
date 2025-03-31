using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieCatalog1._2.Data.Models;

namespace MovieCatalog1._2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Movies> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //var hasher = new PasswordHasher<IdentityUser>();

            //var admin = new IdentityUser
            //{
            //    Id = "1",
            //    UserName = "admin@mail.com",
            //    NormalizedUserName = "ADMIN@MAIL.COM",
            //    Email = "admin@mail.com",
            //    NormalizedEmail = "ADMIN@MAIL.COM",
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "Admin123!")
            //};

            //var guest = new IdentityUser
            //{
            //    Id = "2",
            //    UserName = "guest@mail.com",
            //    NormalizedUserName = "GUEST@MAIL.COM",
            //    Email = "guest@mail.com",
            //    NormalizedEmail = "GUEST@MAIL.COM",
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "Guest123!")
            //};

            //modelBuilder.Entity<IdentityUser>().HasData(admin, guest);

            modelBuilder.Entity<Movies>().HasData(
                new Movies
                {
                    Id = 1,
                    Title = "Inception",
                    Genre = "Sci-Fi",
                    Year = 2010,
                    Description = "A mind-bending thriller about dreams within dreams.",
                    CreatedBy = "Admin",
                    Rating = 8.8,
                    CoverImage = "/images/movies/inception.jpg"
                },
                new Movies
                {
                    Id = 2,
                    Title = "The Dark Knight",
                    Genre = "Action",
                    Year = 2008,
                    Description = "Batman faces off against the Joker in a chaotic fight for Gotham.",
                    CreatedBy = "Admin",
                    Rating = 9.0,
                    CoverImage = "/images/movies/TheDarkKnight.jpg"
                },
                new Movies
                {
                    Id = 3,
                    Title = "The Matrix",
                    Genre = "Sci-Fi",
                    Year = 1999,
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality.",
                    CreatedBy = "Admin",
                    Rating = 8.7,
                    CoverImage = "/images/movies/TheMatrix.jpg"
                }
            );
        }
    }
}
