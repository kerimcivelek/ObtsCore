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
    public class EfOperationDal : EfEntityRepositoryBase<Operation, ObtsContext>, IOperationDal
    {
        

        public List<OperationListDto> OperationList(int CustomerId)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join otype in context.OperationTypes on op.OperationTypeId equals otype.Id
                             join k in context.Users on op.UserId equals k.Id
                             where op.CustomerId == CustomerId
                             select new OperationListDto
                             {
                                 Id = op.Id,
                                 FirstKm = op.FirstKm,
                                 PeriodKm = op.PeriodKm,
                                 LastKm = op.LastKm,
                                 OperationName = otype.Name,
                                 UserName = k.UserName,
                                 RegisterDate = op.RegisterDate,
                                 Note = op.Note

                             };
                return result.ToList();
            }
        }

        public OperationPrintDto OperationPrint(int Id)
        {
            using (var context = new ObtsContext())
            {
                var result = from op in context.Operations
                             join cus in context.Customers on op.CustomerId equals cus.Id
                             join otype in context.OperationTypes on op.OperationTypeId equals otype.Id
                             join f in context.Companies on cus.CompanyId equals f.Id
                             where op.Id == Id
                             select new OperationPrintDto
                             {
                                 Id = op.Id,
                                 CustomerId = cus.Id,
                                 FirstKm = op.FirstKm,
                                 PeriodKm = op.PeriodKm,
                                 LastKm = op.LastKm,
                                 OperationName = otype.Name,
                                 NameSurname = cus.Name + ""+cus.Surname,
                                 RegisterDate = op.RegisterDate,
                                 Gsm = cus.Gsm,
                                 Plaka = cus.Plaka,
                                 Brand = cus.Brand,
                                 Fuel = cus.Fuel,
                                 Year = cus.Year,
                                 CompanyName = f.CompanyName
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
