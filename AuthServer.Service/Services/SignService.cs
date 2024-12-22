using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Service.Services
{
    internal static class SignService  //key i imzalama işlemi yapılır, geriye simetric security key döneceğiz. 
    {
        public static SecurityKey GetSymmetricSecurityKet(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
