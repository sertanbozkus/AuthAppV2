using System.ComponentModel.DataAnnotations;

namespace AuthAppV2.Models
{
    public class LoginRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
