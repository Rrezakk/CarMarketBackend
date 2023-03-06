using System.ComponentModel.DataAnnotations;

namespace CarMarketBackend.Domain.Api.Account;

public class VerifyEmailRequest
{
    [Required]
    public string Token { get; set; }
}