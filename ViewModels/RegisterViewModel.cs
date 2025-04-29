using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Username không được bỏ trống")]
    [StringLength(maximumLength:50,ErrorMessage ="Không thể đăng ký quá 50 ký tự")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Password không được bỏ trống")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Email không được bỏ trống")]
     [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Gender { get; set; } = "Male";
    public string Country { get; set; } = "VN";
}

public class Country
{
    public string Id { get; set; }
    public string Name { get; set; }
}
public static class ListCountry
{
    public static List<Country> Values = new List<Country>();
    static ListCountry()
    {
        Values.Add(new Country { Id = "VN", Name = "Việt Nam" });
        Values.Add(new Country { Id = "CN", Name = "China" });
        Values.Add(new Country { Id = "EN", Name = "EN" });
    }
    public static void AddCountry(Country newCountry)
    {
        Values.Add(newCountry);
    }
}
