using System.ComponentModel.DataAnnotations;

namespace AuthAppV2.Models
{
    public class RegisterRequest
    {
        [EmailAddress(ErrorMessage = "Lütfen Email Formatında Veri Giriniz.")]
        [Required(ErrorMessage = "Email girmek zorunludur.")]
        [Length(15,50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre girilmek zorundadır.")]
        public string Password { get; set; }

        [Compare(nameof(Password),ErrorMessage = "Şifreler Eşleşmiyor.")]
        public string PasswordConfirm { get; set; }
    }
}
