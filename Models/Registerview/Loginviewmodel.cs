using System.ComponentModel.DataAnnotations;

namespace identity3.Models.Registerview
{
    public class Loginviewmodel
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
