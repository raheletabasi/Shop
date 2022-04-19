using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Account.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "لطفا نام را وارد نمایید!")]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا نام خانوادرگی را وارد نمایید!")]
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Required(ErrorMessage = "لطفا ایمیل را وارد نمایید!")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "لطفا رمزعبور را وارد نمایید!")]
        [Display(Name = "رمزعبور")]
        public string Password { get; set; }

        [Required(ErrorMessage = "لطفا تکرار رمزعبور را وارد نمایید!")]
        [Display(Name = "تکرار رمزعبور")]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Display(Name = "موبایل")]
        public string Mobile { get; set; }
    }
}
