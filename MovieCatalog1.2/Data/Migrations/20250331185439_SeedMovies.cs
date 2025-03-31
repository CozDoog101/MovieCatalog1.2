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
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "CreatedBy", "Description", "Genre", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "/images/movies/inception.jpg", "Admin", "A mind-bending thriller about dreams within dreams.", "Sci-Fi", 8.8000000000000007, "Inception", 2010 },
                    { 2, "/images/movies/darkknight.jpg", "Admin", "Batman faces off against the Joker in a chaotic fight for Gotham.", "Action", 9.0, "The Dark Knight", 2008 },
                    { 3, "/images/movies/matrix.jpg", "Admin", "A computer hacker learns from mysterious rebels about the true nature of his reality.", "Sci-Fi", 8.6999999999999993, "The Matrix", 1999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");
        }
    }
}
