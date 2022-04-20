using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Account.Models
{
    public class LoginViewModel
    {       
        [Required(ErrorMessage = "لطفا ایمیل را وارد نمایید!")]       
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "لطفا پسورد را وارد نمایید!")]
        [Display(Name = "رمز عبور")]
        [Remote("","")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
