﻿using System.ComponentModel.DataAnnotations;

namespace _0817mvc.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        [Display(Description ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Description ="First Name")]
        public string FirstName { get; set; }
    }
}