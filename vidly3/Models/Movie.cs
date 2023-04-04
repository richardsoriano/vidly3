using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace vidly3.Models
{
    public class Movie
    {
        public int Id { get; set; }
     
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name="Date of Release")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name="Date Added")]
        public DateTime AddedDate { get; set; }
        public int NumberInStock { get; set; }

        public GenreType GenreType { get; set; }
        [Display(Name = "Genre Type")]
        public byte GenreTypeId { get; set; }

    }
}
