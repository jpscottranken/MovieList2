using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieListApp.Models
{
    public class Movie
    {
        public int MovieId { get; set; }            //  Primary key

        [Required(ErrorMessage = "Please Enter Movie Name.")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter Movie Release Year.")]
        [Range(1889, 2100, ErrorMessage = "Year Must Be Between 1889 - 2100")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Rating.")]
        [Range(1, 5, ErrorMessage = "Rating Must Be Between 1 - 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Genre.")]
        public string GenreId { get; set; } = string.Empty;

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year.ToString();
    }
}
