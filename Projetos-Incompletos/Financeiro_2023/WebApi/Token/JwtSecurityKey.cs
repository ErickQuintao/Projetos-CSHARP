using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace WebApi.Token
{
    public class JwtSecurityKey
    {
        public DateTime ValidTo { get; internal set; }

        public static SymmetricSecurityKey Create(string secret)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
        }

        public static implicit operator JwtSecurityKey(JwtSecurityToken v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator JwtSecurityKey(SecurityKey v)
        {
            throw new NotImplementedException();
        }
    }
}
