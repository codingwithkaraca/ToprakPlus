using System.ComponentModel.DataAnnotations;

namespace ToprakPlus.Entities.ViewModels;

public class UserVM
{
    public UserVM()
    {
    }

    public UserVM(string userName, string email, string phone, string password)
    {
        UserName = userName;
        Email = email;
        Phone = phone;
        Password = password;
    }

    [Required(ErrorMessage = "Bu alan gereklidir")]
    [Display(Name = "Kullanıcı adı")]
    public string UserName { get; set; }
    
    [EmailAddress(ErrorMessage = "Geçerli email formatı giriniz")]
    [Required(ErrorMessage = "Bu alan gereklidir")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Bu alan gereklidir")]
    [Display(Name = "Telefon")]
    public string Phone { get; set; }
    
    [Required(ErrorMessage = "Bu alan gereklidir")]
    [Display(Name = "Şifre")]
    public string Password { get; set; }
    
    [Compare(nameof(Password), ErrorMessage = "Şifreleriniz aynı değil")]
    [Required(ErrorMessage = "Bu alan gereklidir")]
    [Display(Name = "Şifre Tekrar")]
    public string PasswordConfirm { get; set; }
}