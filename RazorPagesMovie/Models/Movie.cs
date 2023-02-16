using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(40, MinimumLength = 4)]
        [Required]       
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(3, 2)")] 
        [DataType(DataType.Currency)]
        [Range(1,250)]
        public decimal Price { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string Rating {get; set;}
    }
}