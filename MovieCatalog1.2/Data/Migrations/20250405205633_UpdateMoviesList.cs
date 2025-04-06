using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCatalog1._2.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMoviesList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoverImage", "Description", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "/images/movies/thedeparted.jpg", "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in Boston.", "Crime", 8.5, "The Departed", 2006 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoverImage", "Description", "Genre", "Rating", "Title", "Year" },
                values: new object[] { "/images/movies/shawshank.jpg", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Drama", 9.3000000000000007, "The Shawshank Redemption", 1994 });
        }
    }
}
