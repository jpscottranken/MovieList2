using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieListApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetupForMovieApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Name", "Rating", "Year" },
                values: new object[,]
                {
                    { 1, "Psycho", 5, 1960 },
                    { 2, "The Matrix", 4, 1999 },
                    { 3, "Dune", 3, 2023 },
                    { 4, "The Silence of the Lambs", 5, 1991 },
                    { 5, "2001: A Space Odyssey", 2, 1968 },
                    { 6, "The Godfather", 5, 1972 },
                    { 7, "Black Panther", 4, 2018 },
                    { 8, "Interstellar", 4, 2014 },
                    { 9, "Pulp Fiction", 5, 1994 },
                    { 10, "Parasite", 2, 2019 },
                    { 11, "Raiders of the Lost Ark", 5, 1981 },
                    { 12, "Get Out", 5, 2017 },
                    { 13, "Joker", 5, 2019 },
                    { 14, "Inception", 5, 2010 },
                    { 15, "The Fellowship of the Ring", 5, 2001 },
                    { 16, "La La Land", 5, 2016 },
                    { 17, "The Avengers", 4, 2012 },
                    { 18, "The Terminator", 3, 1984 },
                    { 19, "Frozen", 5, 2013 },
                    { 20, "Back to the Future", 4, 1985 },
                    { 21, "Mad Max: Fury Road", 4, 2015 },
                    { 22, "Star Wars: Episode IV - A New Hope", 2, 1977 },
                    { 23, "Gladiator", 5, 2000 },
                    { 24, "The Dark Knight", 4, 2008 },
                    { 25, "The Revenant", 3, 2015 }
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
