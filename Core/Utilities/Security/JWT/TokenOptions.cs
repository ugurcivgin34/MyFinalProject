using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Audience { get; set; } //tokenin kullanıcı kitlesi
        public string Issuer { get; set; } //imzalayan gibi düşünebilir
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
