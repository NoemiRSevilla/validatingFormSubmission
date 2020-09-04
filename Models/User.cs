using System.ComponentModel.DataAnnotations;

namespace validatingFormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name="First Name")]
        public string First_Name { get; set; }
        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Required]
        [Range(12,90)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}