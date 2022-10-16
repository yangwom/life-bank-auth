using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LifeBankAuth.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using LifeBank.Constants;


namespace LifeBankAuth.Services
{
    public class TokenGenerator
    {
        /// <summary>
        /// This function is to Generate Token 
        /// </summary>
        /// <returns>A string, the token JWT</returns>
        public string Generate(Client client)
        {
           var tokenHandler = new JwtSecurityTokenHandler();
           var tokenDescriptor = new SecurityTokenDescriptor()
           {
            Subject = AddClaims(client),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(TokenConstants.Secret)), SecurityAlgorithms.HmacSha256Signature),
            Expires = DateTime.Now.AddDays(1)
            
           };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        /// <summary>
        /// Function that adds the claims to the token
        /// </summary>
        /// <param name="client"> A client object value</param>
        /// <returns>Returns an object of type ClaimsIdentity</returns>
        private ClaimsIdentity AddClaims(Client client)
        {
            var claims = new ClaimsIdentity();
            string type = ClientTypeEnum.PessoaFisica.ToString();
            if (client.IsCompany) type = ClientTypeEnum.PessoaJuridica.ToString();

            claims.AddClaim(new Claim(ClaimTypes.Name, client.Name));
            claims.AddClaim(new Claim("Currency", client.Currency.ToString()));
            claims.AddClaim(new Claim("ClientType", type));


            return claims;
        }
    }
}