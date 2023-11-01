namespace Identity.Application.Common.Settings;

public class JwtSettings
{
    public bool ValidateIssuer { get; set; }
    public string ValidIssuer { get; set; } = default!;
    public bool ValidateAudience { get; set; }
    public string ValidAudience { get; set; }
    public bool ValidateLifeTime { get; set; }
    public int ExpirationTimeInMinutes { get; set; }
    public bool ValidateIssuerSigningKey { get; set; }
    public string SecretKey { get; set; }
}
