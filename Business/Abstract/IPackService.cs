using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPackService
    {
        IDataResult<List<Pack>> GetList();
        IResult Add(Pack model);
        IResult Delete(Pack model);

      
    }
}
