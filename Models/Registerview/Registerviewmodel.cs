using System.ComponentModel.DataAnnotations;

namespace identity3.Models.Registerview
{
 
    
    public class Registerviewmodel
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Compare("Password")]
        public string PasswordConfirmed { get; set; }
        public string Phone { get; set; }
    }
}
