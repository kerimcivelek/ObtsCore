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
    public class EfVehicleBrandDal : EfEntityRepositoryBase<VehicleBrand, ObtsContext>, IVehicleBrandDal
    {
        public List<BrandDto> BrandList()
        {
            using (var context = new ObtsContext())
            {
                var result = from Brands in context.VehicleBrands
                             select new BrandDto
                             {
                                 BrandName = Brands.BrandName  +" - " + Brands.Model
                             };
                return result.ToList();
            }
        }
    }
}
