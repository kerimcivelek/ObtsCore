using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Dtos
{
    public class LoginDto:IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Msg { get; set; }
    }
}
