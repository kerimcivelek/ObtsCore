using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPackDetailService
    {
        IDataResult<List<PackDetail>> GetListPackId(int Id);
        IResult Add(PackDetail model);
        IResult Delete(PackDetail model);
    }
}
