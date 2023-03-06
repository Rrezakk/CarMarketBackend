using System.ComponentModel.DataAnnotations;

namespace CarMarketBackend.Domain.Api.Account;

public class ValidateResetTokenRequest
{
    [Required]
    public string Token { get; set; }
}