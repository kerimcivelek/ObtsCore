using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class UserListDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
    }
}
