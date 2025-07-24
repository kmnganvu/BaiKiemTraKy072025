using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; } = default!;
        [Required]
        public string FullName { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
    }
}