using Microsoft.AspNetCore.DataProtection;
using N65_HT_1.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace N65_HT_1.Service;

public class VerificationTokenService
{
    private readonly IDataProtector _protector;

    public VerificationTokenService(IDataProtectionProvider protector)
    {
        _protector = protector.CreateProtector(nameof(VerificationTokenService));
    }

    public string GetToken(User user)
    {
        var token = _protector.Protect(JsonConvert.SerializeObject(user));
        return token;
    }
    public int GenerateCode() => new Random().Next(1000,10000);

    public User Decode(string token)
    {
        var decode = _protector.Unprotect(token);

        return JsonConvert.DeserializeObject<User>(decode);
    }
}
