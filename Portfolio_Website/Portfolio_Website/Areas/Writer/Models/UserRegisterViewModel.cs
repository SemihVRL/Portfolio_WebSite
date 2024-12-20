﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio_Website.Areas.Writer.Models
{
   
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adını girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadını girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Lütfen kullanıcı adını girin")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Lütfen mail girin")]
        public string Mail { get; set; }
    }
}
