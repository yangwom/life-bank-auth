using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LifeBankAuth.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Function that adds the claims to the token
        /// </summary>
        /// <param name="client"> A client object value</param>
        /// <returns>Returns an object of type ClaimsIdentity</returns>
        private ClaimsIdentity AddClaims(Client client)
        {
            throw new NotImplementedException();
        }
    }
}