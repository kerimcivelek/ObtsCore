using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface INoteService
    {
        IDataResult<List<Note>> GetList(int CustomerId);
        IResult Add(Note model);
        IResult Delete(Note model);
      
    }
}
