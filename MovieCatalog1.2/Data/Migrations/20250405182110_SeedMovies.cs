using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieCatalog1._2.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "/images/movies/TheDarkKnight.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CoverImage",
                value: "/images/movies/TheMatrix.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "Description", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 4, "/images/movies/interstellar.jpg", "Admin", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Sci-Fi", 8.5999999999999996, "Interstellar", 2014 },
                    { 5, "/images/movies/fightclub.jpg", "Admin", "An insomniac office worker and a devil-may-care soap maker form an underground fight club.", "Drama", 8.8000000000000007, "Fight Club", 1999 },
                    { 6, "/images/movies/pulpfiction.jpg", "Admin", "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Crime", 8.9000000000000004, "Pulp Fiction", 1994 },
                    { 7, "/images/movies/forrestgump.jpg", "Admin", "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.", "Drama", 8.8000000000000007, "Forrest Gump", 1994 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "/images/movies/darkknight.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CoverImage",
                value: "/images/movies/matrix.jpg");
        }
    }
}
