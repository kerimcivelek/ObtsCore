
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IAuthService
    {
        IDataResult<User> Register(RegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(LoginDto userForLoginDto);
        IDataResult<User> Update(RegisterDto userForRegisterDto, string password);
        IResult UserExists(string username);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
