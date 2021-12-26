using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        IResult Update(User user);
        User GetByUser(string username);
        IDataResult<User> GetByUserKey(Guid key);
        IDataResult<RegisterDto> GetByUserId(int Id);

        IDataResult<List<UserListDto>> GetUserList();

    }
}
