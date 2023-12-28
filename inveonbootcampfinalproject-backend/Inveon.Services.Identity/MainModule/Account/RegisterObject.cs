using System.ComponentModel.DataAnnotations;

namespace Inveon.Services.Identity.MainModule.Account;

public class RegisterObject
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required]
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}