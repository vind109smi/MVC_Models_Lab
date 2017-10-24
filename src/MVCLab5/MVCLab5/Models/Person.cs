using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab5.Models
{
    public class Person
    {
        // Create constructor for Person class
        public Person()
        { }
            [Required(ErrorMessage ="Invalid First Name")]
             public string firstName { get; set; }
            [Required(ErrorMessage = "Invalid Last Name")]
            public string lastName { get; set; }
            // Adding a datetype annotation to represent date as input
            [DataType(DataType.Date)]
            [Required(ErrorMessage ="Enter birthday")]
            public DateTime birthDay { get; set; }
                  
        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - birthDay.Year;
                if (now < birthDay.AddYears(age)) age--;
                return age;
            }
        }
    }
 }
       
