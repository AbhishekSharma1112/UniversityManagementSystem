using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Course
    {

        [Key]
         public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
        public string Department { get; set; }
    }
}
