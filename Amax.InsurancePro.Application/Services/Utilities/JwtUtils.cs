using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Amax.InsurancePro.Application.Services.Utilities;

public class JwtUtils : IJwtUtils
{
    private readonly AppSettings _appSettings;

    public JwtUtils(IOptionsSnapshot<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }

    public async Task<string> GenerateJwtToken(UserLoginInfo user)
    {
        // generate token that is valid for 1 day
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Jwt.Key);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("uid", user.UserId.ToString()),
                new Claim("lid", user.UserLoginId),
                new Claim("agright", JsonSerializer.Serialize(user.AgentRights)),
                new Claim(ClaimTypes.Role, user.AgentRights.IsAdmin ? "admin" : "agent"), // TODO improve, single signon
            }),
            Issuer = _appSettings.Jwt.Issuer,
            Audience = _appSettings.Jwt.Audience,
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return await Task.Run(() => tokenHandler.WriteToken(token));
    }

    public UserLoginInfo ValidateJwtToken(string token)
    {
        if (token == null)
            return null;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Keys.Secret);
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "uid").Value);
            var loginId = jwtToken.Claims.First(x => x.Type == "lid").Value;
            var agentRights = JsonSerializer.Deserialize<AgentRights>(jwtToken.Claims.First(x => x.Type == "agright").Value);

            // return user id from JWT token if validation successful
            return new UserLoginInfo { UserId = userId, UserLoginId = loginId, AgentRights = agentRights };
        }
        catch
        {
            // return null if validation fails
            return null;
        }
    }
}
