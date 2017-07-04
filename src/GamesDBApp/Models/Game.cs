using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesDBApp.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]*$", ErrorMessage = "Title must contain only alphanumeric characters.")]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]*$", ErrorMessage = "Genre must contain only alphanumeric characters.")]
        public string Genre { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]*$", ErrorMessage = "Developer must contain only alphanumeric characters.")]
        public string Developer { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        
    }
}
