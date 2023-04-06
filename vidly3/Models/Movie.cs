using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace vidly3.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name of Movie")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Date Of Release is required")]
        [Display(Name="Date of Release")]
        public DateTime ReleaseDate { get; set; }
        
        [Required(ErrorMessage="Date Added is required")]
        [Display(Name="Date Added")]
        public DateTime AddedDate { get; set; }

        [Range(1, 20)]
        [Display(Name="Number In Stock")]
        public int NumberInStock { get; set; }

        public GenreType GenreType { get; set; }
        [Display(Name = "Genre Type")]
        public byte GenreTypeId { get; set; }

    }
}
