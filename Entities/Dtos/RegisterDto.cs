using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Dtos
{
    public class RegisterDto : IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }
        public Guid key { get; set; }
        public bool Status { get; set; }
        public string Role { get; set; }
    }
}
