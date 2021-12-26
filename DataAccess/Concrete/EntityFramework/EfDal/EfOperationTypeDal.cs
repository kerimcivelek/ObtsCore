using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework.EfDal
{
    public class EfOperationTypeDal : EfEntityRepositoryBase<OperationType, ObtsContext>, IOperationTypeDal
    {
        

        public List<OperationTypeDto> GetList()
        {
            using (var context = new ObtsContext())
            {
                var result = from i in context.OperationTypes
                             select new OperationTypeDto
                             {
                                 OperationTypeId = i.Id,
                                 Name = i.Name
                                 
                             };
                 return result.ToList();
            }
        }
    }
}
