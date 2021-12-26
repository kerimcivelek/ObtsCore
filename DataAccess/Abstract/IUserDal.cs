using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserDal :IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);

        List<UserListDto> GetUserList();

        RegisterDto GetByUser(int Id);
    }
}
