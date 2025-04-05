using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalog1._2.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "/images/movies/THeDarkNight.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "Description", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 8, "/images/movies/thegodfather.jpg", "Admin", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Crime", 9.1999999999999993, "The Godfather", 1972 },
                    { 9, "/images/movies/shawshank.jpg", "Admin", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Drama", 9.3000000000000007, "The Shawshank Redemption", 1994 },
                    { 10, "/images/movies/schindlerslist.jpg", "Admin", "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "History", 9.0, "Schindler's List", 1993 },
                    { 11, "/images/movies/gladiator.jpg", "Admin", "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Action", 8.5, "Gladiator", 2000 },
                    { 12, "/images/movies/silenceofthelambs.jpg", "Admin", "A young FBI cadet seeks the advice of an imprisoned cannibal killer to help catch another serial killer.", "Thriller", 8.5999999999999996, "The Silence of the Lambs", 1991 },
                    { 13, "/images/movies/savingprivateryan.jpg", "Admin", "Following the Normandy landings, a group of U.S. soldiers must find and bring home a paratrooper whose brothers have been killed in action.", "War", 8.5999999999999996, "Saving Private Ryan", 1998 },
                    { 14, "/images/movies/lionking.jpg", "Admin", "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.", "Animation", 8.5, "The Lion King", 1994 },
                    { 15, "/images/movies/prestige.jpg", "Admin", "Two magicians engage in a bitter rivalry, each trying to best the other with their tricks and illusions.", "Mystery", 8.5, "The Prestige", 2006 },
                    { 16, "/images/movies/avatar.jpg", "Admin", "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", "Sci-Fi", 7.7999999999999998, "Avatar", 2009 },
                    { 17, "/images/movies/shawshank.jpg", "Admin", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Drama", 9.3000000000000007, "The Shawshank Redemption", 1994 },
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
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "/images/movies/TheDarkKnight.jpg");
        }
    }
}
