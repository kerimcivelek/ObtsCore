using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManeger : IUserService
    {
        private IUserDal _userDal;

        public UserManeger(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
              _userDal.Add(user);
        }

       
        public User GetByUser(string username)
        {
            return _userDal.Get(x=> x.UserName== username);
        }

        public IDataResult<RegisterDto> GetByUserId(int Id)
        {
            return new SuccessDataResult<RegisterDto>(_userDal.GetByUser(Id));
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<List<UserListDto>> GetUserList()
        {
            return new SuccessDataResult<List< UserListDto>>(_userDal.GetUserList());
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }

        IDataResult<User> IUserService.GetByUserKey(Guid key)
        {
            return new SuccessDataResult<User>(_userDal.Get(x => x.key == key));
        }
    }
}
