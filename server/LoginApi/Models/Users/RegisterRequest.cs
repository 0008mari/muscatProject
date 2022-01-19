using System.ComponentModel.DataAnnotations;

namespace LoginApi.Models.Users
{
    public class RegisterRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
    }
}