using System.ComponentModel.DataAnnotations;

namespace MovieCatalog1._2.Data.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public double Rating { get; set; }
        public string CoverImage { get; set; } 
    }
}
