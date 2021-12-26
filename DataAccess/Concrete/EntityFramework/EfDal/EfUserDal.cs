using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework.EfDal
{
    public class EfUserDal : EfEntityRepositoryBase<User, ObtsContext>, IUserDal
    {
        public RegisterDto GetByUser(int Id)
        {
            using (var context = new ObtsContext())
            {
                var result = from u in context.Users
                             where u.Id == Id
                             select new RegisterDto 
                             {
                                 Id = u.Id,
                                 UserName = u.UserName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Status = u.Status,
                                 Role = u.Role,
                                 key = u.key
                             };
                return result.FirstOrDefault();
               
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ObtsContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<UserListDto> GetUserList()
        {
            using (var context = new ObtsContext())
            {
                var result = from u in context.Users 
                             join c in context.Companies on u.CompanyId equals c.Id
                             where u.Status==true
                             select new UserListDto
                             {
                                 Id = u.Id,
                                 UserName = u.UserName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = c.CompanyName
                             };
                return result.ToList();

            }
        }
    }
}
