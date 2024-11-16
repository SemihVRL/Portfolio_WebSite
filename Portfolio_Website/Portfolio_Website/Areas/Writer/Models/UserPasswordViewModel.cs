using System.ComponentModel.DataAnnotations;

namespace Portfolio_Website.Areas.Writer.Models
{
    public class UserPasswordViewModel
    {
        [Required(ErrorMessage = "Mevcut şifrenizi giriniz")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Yeni şifrenizi giriniz")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalı")]
        
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Yeni şifrenizi tekrar giriniz")]
        [Compare("NewPassword", ErrorMessage = "Şifreler uyumlu değil")]
        
        public string ConfirmNewPassword { get; set; }
    }
}
