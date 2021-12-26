using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class NoteManeger : INoteService
    {
        private INoteDal _noteDal;

        public NoteManeger(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }
        public IResult Add(Note model)
        {
            _noteDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Note model)
        {
            _noteDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Note>> GetList(int CustomerId)
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetList(x=> x.CustomerId==CustomerId).ToList());
        }
    }
}
