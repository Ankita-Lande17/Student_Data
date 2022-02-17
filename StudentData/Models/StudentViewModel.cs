using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentData.Models
{
    public class StudentViewModel
    {

    }
    public class Student
    {
        [Display(Name = "RollNumber")]
        [Required]
        public int Roll { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string? Name { get; set; }
        [Display(Name = "Age")]
        [Required]
        public int Age { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

    }
}
