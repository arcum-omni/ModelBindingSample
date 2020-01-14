using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Display(Name = "Full Name")] // [] to add DataAnnotations: ie attribute
        [Required(ErrorMessage = "Full Name Required")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Favorite Number")]
        [Range(1,100, ErrorMessage = "Choose between 1 & 100")]
        //[Required] int is always req'd because it is a value type, int? is nullable and not required
        public int? FavoriteNumber { get; set; }
    }
}
