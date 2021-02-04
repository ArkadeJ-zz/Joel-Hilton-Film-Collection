using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Joel_Hilton_Film_Collection.Models
{
    public class Movies
    {
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(1888, 2021, ErrorMessage = "Must be between 1888 and 2021")]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [StringLength(25, ErrorMessage = "Note cannot be more than 25 characters")]
        public string Notes { get; set; }
    }
}
