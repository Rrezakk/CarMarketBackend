using System.ComponentModel.DataAnnotations;

namespace CarMarketBackend.Domain.Api.Account;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}