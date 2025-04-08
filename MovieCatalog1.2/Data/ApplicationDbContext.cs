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
                    CoverImage = "/images/movies/TheDarkNight.jpg"
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
                },
                new Movies
                {
                    Id = 4,
                    Title = "Interstellar",
                    Genre = "Sci-Fi",
                    Year = 2014,
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    CreatedBy = "Admin",
                    Rating = 8.6,
                    CoverImage = "/images/movies/interstellar.jpg"
                },
                new Movies
                {
                    Id = 5,
                    Title = "Fight Club",
                    Genre = "Drama",
                    Year = 1999,
                    Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club.",
                    CreatedBy = "Admin",
                    Rating = 8.8,
                    CoverImage = "/images/movies/fightclub.jpg"
                },
                new Movies
                {
                    Id = 6,
                    Title = "Pulp Fiction",
                    Genre = "Crime",
                    Year = 1994,
                    Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    CreatedBy = "Admin",
                    Rating = 8.9,
                    CoverImage = "/images/movies/pulpfiction.jpg"
                },
                new Movies
                {
                    Id = 7,
                    Title = "Forrest Gump",
                    Genre = "Drama",
                    Year = 1994,
                    Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.",
                    CreatedBy = "Admin",
                    Rating = 8.8,
                    CoverImage = "/images/movies/forrestgump.jpg"
                },
                new Movies
                {
                    Id = 8,
                    Title = "The Godfather",
                    Genre = "Crime",
                    Year = 1972,
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    CreatedBy = "Admin",
                    Rating = 9.2,
                    CoverImage = "/images/movies/thegodfather.jpg"
                },
                new Movies
                {
                    Id = 9,
                    Title = "The Shawshank Redemption",
                    Genre = "Drama",
                    Year = 1994,
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    CreatedBy = "Admin",
                    Rating = 9.3,
                    CoverImage = "/images/movies/shawshank.jpg"
                },
                new Movies
                {
                    Id = 10,
                    Title = "Schindler's List",
                    Genre = "History",
                    Year = 1993,
                    Description = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    CreatedBy = "Admin",
                    Rating = 9.0,
                    CoverImage = "/images/movies/schindlerslist.jpg"
                },
                new Movies
                {
                    Id = 11,
                    Title = "Gladiator",
                    Genre = "Action",
                    Year = 2000,
                    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                    CreatedBy = "Admin",
                    Rating = 8.5,
                    CoverImage = "/images/movies/gladiator.jpg"
                },
                new Movies
                {
                    Id = 12,
                    Title = "The Silence of the Lambs",
                    Genre = "Thriller",
                    Year = 1991,
                    Description = "A young FBI cadet seeks the advice of an imprisoned cannibal killer to help catch another serial killer.",
                    CreatedBy = "Admin",
                    Rating = 8.6,
                    CoverImage = "/images/movies/silenceofthelambs.jpg"
                },
                new Movies
                {
                    Id = 13,
                    Title = "Saving Private Ryan",
                    Genre = "War",
                    Year = 1998,
                    Description = "Following the Normandy landings, a group of U.S. soldiers must find and bring home a paratrooper whose brothers have been killed in action.",
                    CreatedBy = "Admin",
                    Rating = 8.6,
                    CoverImage = "/images/movies/savingprivateryan.jpg"
                },
                new Movies
                {
                    Id = 14,
                    Title = "The Lion King",
                    Genre = "Animation",
                    Year = 1994,
                    Description = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.",
                    CreatedBy = "Admin",
                    Rating = 8.5,
                    CoverImage = "/images/movies/lionking.jpg"
                },
                new Movies
                {
                    Id = 15,
                    Title = "The Prestige",
                    Genre = "Mystery",
                    Year = 2006,
                    Description = "Two magicians engage in a bitter rivalry, each trying to best the other with their tricks and illusions.",
                    CreatedBy = "Admin",
                    Rating = 8.5,
                    CoverImage = "/images/movies/prestige.jpg"
                },
                new Movies
                {
                    Id = 16,
                    Title = "Avatar",
                    Genre = "Sci-Fi",
                    Year = 2009,
                    Description = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                    CreatedBy = "Admin",
                    Rating = 7.8,
                    CoverImage = "/images/movies/avatar.jpg"
                },
                new Movies
                {
                    Id = 17,
                    Title = "The Departed",
                    Genre = "Crime",
                    Year = 2006,
                    Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in Boston.",
                    CreatedBy = "Admin",
                    Rating = 8.5,
                    CoverImage = "/images/movies/thedeparted.jpg"
                },
                new Movies
                {
                    Id = 18,
                    Title = "Shutter Island",
                    Genre = "Thriller",
                    Year = 2010,
                    Description = "A U.S. Marshal investigates the disappearance of a murderer who escaped from a mental institution.",
                    CreatedBy = "Admin",
                    Rating = 8.1,
                    CoverImage = "/images/movies/shutterisland.jpg"
                },
                new Movies
                {
                    Id = 19,
                    Title = "The Revenant",
                    Genre = "Adventure",
                    Year = 2015,
                    Description = "A frontiersman on a quest for survival and revenge against those who left him for dead.",
                    CreatedBy = "Admin",
                    Rating = 8.0,
                    CoverImage = "/images/movies/revenant.jpg"
                },
                new Movies
                {
                    Id = 20,
                    Title = "La La Land",
                    Genre = "Romance",
                    Year = 2016,
                    Description = "A jazz musician and an aspiring actress fall in love, but their ambitions threaten to tear them apart.",
                    CreatedBy = "Admin",
                    Rating = 8.0,
                    CoverImage = "/images/movies/lalaland.jpg"
                },
                new Movies
                {
                    Id = 21,
                    Title = "The Grand Budapest Hotel",
                    Genre = "Comedy",
                    Year = 2014,
                    Description = "The adventures of a legendary concierge at a famous European hotel between the wars.",
                    CreatedBy = "Admin",
                    Rating = 8.1,
                    CoverImage = "/images/movies/grandbudapest.jpg"
                },
                new Movies
                {
                    Id = 22,
                    Title = "Gone Girl",
                    Genre = "Mystery",
                    Year = 2014,
                    Description = "A man becomes the prime suspect in the disappearance of his wife, unraveling secrets along the way.",
                    CreatedBy = "Admin",
                    Rating = 8.1,
                    CoverImage = "/images/movies/gonegirl.jpg"
                },
                new Movies
                {
                    Id = 23,
                    Title = "Her",
                    Genre = "Romance",
                    Year = 2013,
                    Description = "A man develops a romantic relationship with an artificial intelligence system.",
                    CreatedBy = "Admin",
                    Rating = 8.0,
                    CoverImage = "/images/movies/her.jpg"
                },
                new Movies
                {
                    Id = 24,
                    Title = "Blade Runner 2049",
                    Genre = "Sci-Fi",
                    Year = 2017,
                    Description = "A new blade runner unearths a long-buried secret that could plunge what's left of society into chaos.",
                    CreatedBy = "Admin",
                    Rating = 8.0,
                    CoverImage = "/images/movies/bladerunner2049.jpg"
                },
                new Movies
                {
                    Id = 25,
                    Title = "Django Unchained",
                    Genre = "Western",
                    Year = 2012,
                    Description = "A freed slave sets out to rescue his wife from a brutal plantation owner.",
                    CreatedBy = "Admin",
                    Rating = 8.4,
                    CoverImage = "/images/movies/django.jpg"
                },
                new Movies
                {
                    Id = 26,
                    Title = "The Martian",
                    Genre = "Sci-Fi",
                    Year = 2015,
                    Description = "An astronaut is stranded on Mars and must use his ingenuity to survive while awaiting rescue.",
                    CreatedBy = "Admin",
                    Rating = 8.0,
                    CoverImage = "/images/movies/martian.jpg"
                },
                new Movies
                {
                    Id = 27,
                    Title = "Mad Max: Fury Road",
                    Genre = "Action",
                    Year = 2015,
                    Description = "In a post-apocalyptic wasteland, Max teams up with a rebel warrior to escape a tyrannical warlord.",
                    CreatedBy = "Admin",
                    Rating = 8.1,
                    CoverImage = "/images/movies/madmax.jpg"
                }
            );
        }
    }
}
