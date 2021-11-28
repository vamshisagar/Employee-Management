using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required] //used for validation
        [MaxLength(15)]
        public String Name { get; set; }
        [Required]
        [RegularExpression("[A-Za-z0-9^~!#$%^&*]+@gmail.com",ErrorMessage ="Invalid Email address")]
        public String Email { get; set; }
        [Required(ErrorMessage ="Department Cannot be null")]
        public Dept? Department { get; set; }

    }
}
