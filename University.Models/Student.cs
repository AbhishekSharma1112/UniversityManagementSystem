﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public float Gpa { get; set; }
    }
}
