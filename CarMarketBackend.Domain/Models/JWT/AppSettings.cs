namespace CarMarketBackend.Domain.Models.JWT;

public class AppSettings
{
    public string Secret { get; set; }
    public int TokenLifeTimeMinutes { get; set; }//access token lifetime in minutes

    // refresh token time to live (in days), inactive tokens are
    // automatically deleted from the database after this time
    public int RefreshTokenTtl { get; set; }

    public string EmailFrom { get; set; }
    public string SmtpHost { get; set; }
    public int SmtpPort { get; set; }
    public string SmtpUser { get; set; }
    public string SmtpPass { get; set; }
}