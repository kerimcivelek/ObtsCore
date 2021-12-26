using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public Guid key { get; set; }
        public int CompanyId { get; set; }
        public string Role { get; set; }
    }
}
