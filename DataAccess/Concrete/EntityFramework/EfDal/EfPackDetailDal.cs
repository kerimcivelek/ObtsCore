using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.EfDal
{
   public class EfPackDetailDal : EfEntityRepositoryBase<PackDetail, ObtsContext>, IPackDetailDal
    {
    }
}
