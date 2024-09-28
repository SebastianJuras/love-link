using System.ComponentModel.DataAnnotations;

namespace API;

public class RegisterDto
{
    [Required]
    [MaxLength(100)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [MaxLength(8)]
    public string Password { get; set; } = string.Empty;
}
