using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class VehicleBrandManeger : IVehicleBrandService
    {
        private IVehicleBrandDal _vehicleBrandDal;
        public VehicleBrandManeger(IVehicleBrandDal  vehicleBrandDal)
        {
            _vehicleBrandDal = vehicleBrandDal;
        }

        public IDataResult<List<BrandDto>> GetList()
        {
            return new SuccessDataResult<List<BrandDto>>(_vehicleBrandDal.BrandList());
        }
    }
}
