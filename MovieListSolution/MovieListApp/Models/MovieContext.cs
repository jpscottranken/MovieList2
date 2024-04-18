using Microsoft.EntityFrameworkCore;

namespace MovieListApp.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() { }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        //  Add movie data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Psycho",
                    Year = 1960,
                    Rating = 5,
                    GenreId = "H"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "The Matrix",
                    Year = 1999,
                    Rating = 4,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Dune",
                    Year = 2023,
                    Rating = 3,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 4,
                    Name = "The Silence of the Lambs",
                    Year = 1991,
                    Rating = 5,
                    GenreId = "H"
                },
                new Movie
                {
                    MovieId = 5,
                    Name = "2001: A Space Odyssey",
                    Year = 1968,
                    Rating = 2,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 6,
                    Name = "The Godfather",
                    Year = 1972,
                    Rating = 5,
                    GenreId = "CD"
                },
                new Movie
                {
                    MovieId = 7,
                    Name = "Black Panther",
                    Year = 2018,
                    Rating = 4,
                    GenreId = "A"
                },
                new Movie
                {
                    MovieId = 8,
                    Name = "Interstellar",
                    Year = 2014,
                    Rating = 4,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 9,
                    Name = "Pulp Fiction",
                    Year = 1994,
                    Rating = 5,
                    GenreId = "CD"
                },
                new Movie
                {
                    MovieId = 10,
                    Name = "Parasite",
                    Year = 2019,
                    Rating = 2,
                    GenreId = "D"
                },
                new Movie
                {
                    MovieId = 11,
                    Name = "Raiders of the Lost Ark",
                    Year = 1981,
                    Rating = 5,
                    GenreId = "A"
                },
                new Movie
                {
                    MovieId = 12,
                    Name = "Get Out",
                    Year = 2017,
                    Rating = 5,
                    GenreId = "H"
                },
                new Movie
                {
                    MovieId = 13,
                    Name = "Joker",
                    Year = 2019,
                    Rating = 5,
                    GenreId = "D"
                },
                new Movie
                {
                    MovieId = 14,
                    Name = "Inception",
                    Year = 2010,
                    Rating = 5,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 15,
                    Name = "The Fellowship of the Ring",
                    Year = 2001,
                    Rating = 5,
                    GenreId = "F"
                },
                new Movie
                {
                    MovieId = 16,
                    Name = "La La Land",
                    Year = 2016,
                    Rating = 5,
                    GenreId = "M"
                },
                new Movie
                {
                    MovieId = 17,
                    Name = "The Avengers",
                    Year = 2012,
                    Rating = 4,
                    GenreId = "A"
                },
                new Movie
                {
                    MovieId = 18,
                    Name = "The Terminator",
                    Year = 1984,
                    Rating = 3,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 19,
                    Name = "Frozen",
                    Year = 2013,
                    Rating = 5,
                    GenreId = "F"
                },
                new Movie
                {
                    MovieId = 20,
                    Name = "Back to the Future",
                    Year = 1985,
                    Rating = 4,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 21,
                    Name = "Mad Max: Fury Road",
                    Year = 2015,
                    Rating = 4,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 22,
                    Name = "Star Wars: Episode IV - A New Hope",
                    Year = 1977,
                    Rating = 2,
                    GenreId = "SF"
                },
                new Movie
                {
                    MovieId = 23,
                    Name = "Gladiator",
                    Year = 2000,
                    Rating = 5,
                    GenreId = "D"
                },
                new Movie
                {
                    MovieId = 24,
                    Name = "The Dark Knight",
                    Year = 2008,
                    Rating = 4,
                    GenreId = "H"
                },
                new Movie
                {
                    MovieId = 25,
                    Name = "The Revenant",
                    Year = 2015,
                    Rating = 3,
                    GenreId = "D"
                }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = "A",
                    Name = "Action"
                },
                new Genre
                {
                    GenreId = "CD",
                    Name = "Crime Drama"
                },
                new Genre
                {
                    GenreId = "D",
                    Name = "Drama"
                },
                new Genre
                {
                    GenreId = "F",
                    Name = "Fantasy"
                },
                new Genre
                {
                    GenreId = "H",
                    Name = "Horror"
                },
                new Genre
                {
                    GenreId = "M",
                    Name = "Musical"
                },
                new Genre
                {
                    GenreId = "SF",
                    Name = "Science Fiction"
                }
            );
        }
    }
}
