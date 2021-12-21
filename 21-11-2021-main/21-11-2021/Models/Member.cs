
using System.ComponentModel.DataAnnotations;

namespace _21_11_2021.Models
{
    public class Member
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your university")]
        public string University { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? Status { get; set; }
    }

}
