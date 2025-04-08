using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalog1._2.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "Description", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "/images/movies/inception.jpg", "Admin", "A mind-bending thriller about dreams within dreams.", "Sci-Fi", 8.8000000000000007, "Inception", 2010 },
                    { 2, "/images/movies/TheDarkNight.jpg", "Admin", "Batman faces off against the Joker in a chaotic fight for Gotham.", "Action", 9.0, "The Dark Knight", 2008 },
                    { 3, "/images/movies/TheMatrix.jpg", "Admin", "A computer hacker learns from mysterious rebels about the true nature of his reality.", "Sci-Fi", 8.6999999999999993, "The Matrix", 1999 },
                    { 4, "/images/movies/interstellar.jpg", "Admin", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Sci-Fi", 8.5999999999999996, "Interstellar", 2014 },
                    { 5, "/images/movies/fightclub.jpg", "Admin", "An insomniac office worker and a devil-may-care soap maker form an underground fight club.", "Drama", 8.8000000000000007, "Fight Club", 1999 },
                    { 6, "/images/movies/pulpfiction.jpg", "Admin", "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Crime", 8.9000000000000004, "Pulp Fiction", 1994 },
                    { 7, "/images/movies/forrestgump.jpg", "Admin", "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.", "Drama", 8.8000000000000007, "Forrest Gump", 1994 },
                    { 8, "/images/movies/thegodfather.jpg", "Admin", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Crime", 9.1999999999999993, "The Godfather", 1972 },
                    { 9, "/images/movies/shawshank.jpg", "Admin", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Drama", 9.3000000000000007, "The Shawshank Redemption", 1994 },
                    { 10, "/images/movies/schindlerslist.jpg", "Admin", "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "History", 9.0, "Schindler's List", 1993 },
                    { 11, "/images/movies/gladiator.jpg", "Admin", "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Action", 8.5, "Gladiator", 2000 },
                    { 12, "/images/movies/silenceofthelambs.jpg", "Admin", "A young FBI cadet seeks the advice of an imprisoned cannibal killer to help catch another serial killer.", "Thriller", 8.5999999999999996, "The Silence of the Lambs", 1991 },
                    { 13, "/images/movies/savingprivateryan.jpg", "Admin", "Following the Normandy landings, a group of U.S. soldiers must find and bring home a paratrooper whose brothers have been killed in action.", "War", 8.5999999999999996, "Saving Private Ryan", 1998 },
                    { 14, "/images/movies/lionking.jpg", "Admin", "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.", "Animation", 8.5, "The Lion King", 1994 },
                    { 15, "/images/movies/prestige.jpg", "Admin", "Two magicians engage in a bitter rivalry, each trying to best the other with their tricks and illusions.", "Mystery", 8.5, "The Prestige", 2006 },
                    { 16, "/images/movies/avatar.jpg", "Admin", "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", "Sci-Fi", 7.7999999999999998, "Avatar", 2009 },
                    { 17, "/images/movies/thedeparted.jpg", "Admin", "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in Boston.", "Crime", 8.5, "The Departed", 2006 },
                    { 18, "/images/movies/shutterisland.jpg", "Admin", "A U.S. Marshal investigates the disappearance of a murderer who escaped from a mental institution.", "Thriller", 8.0999999999999996, "Shutter Island", 2010 },
                    { 19, "/images/movies/revenant.jpg", "Admin", "A frontiersman on a quest for survival and revenge against those who left him for dead.", "Adventure", 8.0, "The Revenant", 2015 },
                    { 20, "/images/movies/lalaland.jpg", "Admin", "A jazz musician and an aspiring actress fall in love, but their ambitions threaten to tear them apart.", "Romance", 8.0, "La La Land", 2016 },
                    { 21, "/images/movies/grandbudapest.jpg", "Admin", "The adventures of a legendary concierge at a famous European hotel between the wars.", "Comedy", 8.0999999999999996, "The Grand Budapest Hotel", 2014 },
                    { 22, "/images/movies/gonegirl.jpg", "Admin", "A man becomes the prime suspect in the disappearance of his wife, unraveling secrets along the way.", "Mystery", 8.0999999999999996, "Gone Girl", 2014 },
                    { 23, "/images/movies/her.jpg", "Admin", "A man develops a romantic relationship with an artificial intelligence system.", "Romance", 8.0, "Her", 2013 },
                    { 24, "/images/movies/bladerunner2049.jpg", "Admin", "A new blade runner unearths a long-buried secret that could plunge what's left of society into chaos.", "Sci-Fi", 8.0, "Blade Runner 2049", 2017 },
                    { 25, "/images/movies/django.jpg", "Admin", "A freed slave sets out to rescue his wife from a brutal plantation owner.", "Western", 8.4000000000000004, "Django Unchained", 2012 },
                    { 26, "/images/movies/martian.jpg", "Admin", "An astronaut is stranded on Mars and must use his ingenuity to survive while awaiting rescue.", "Sci-Fi", 8.0, "The Martian", 2015 },
                    { 27, "/images/movies/madmax.jpg", "Admin", "In a post-apocalyptic wasteland, Max teams up with a rebel warrior to escape a tyrannical warlord.", "Action", 8.0999999999999996, "Mad Max: Fury Road", 2015 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
