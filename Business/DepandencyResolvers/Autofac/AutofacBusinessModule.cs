using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.EfDal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DepandencyResolvers.Autofac
{
   public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<DashBoardManeger>().As<IDashBoardService>();
            builder.RegisterType<EfDashBoardDal>().As<IDashBoardDal>();

            builder.RegisterType<UserManeger>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<CompanyManeger>().As<ICompanyService>();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>();

            builder.RegisterType<OperationTypeManeger>().As<IOperationTypeService>();
            builder.RegisterType<EfOperationTypeDal>().As<IOperationTypeDal>();

            builder.RegisterType<ProductManeger>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManeger>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CustomerManeger>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<OperationManeger>().As<IOperationService>();
            builder.RegisterType<EfOperationDal>().As<IOperationDal>();

            builder.RegisterType<OperationDetailManeger>().As<IOperationDetailService>();
            builder.RegisterType<EfOperationDetailDal>().As<IOperationDetailDal>();

            builder.RegisterType<VehicleBrandManeger>().As<IVehicleBrandService>();
            builder.RegisterType<EfVehicleBrandDal>().As<IVehicleBrandDal>();

            builder.RegisterType<PackManeger>().As<IPackService>();
            builder.RegisterType<EfPackDal>().As<IPackDal>();

            builder.RegisterType<PackDetailManeger>().As<IPackDetailService>();
            builder.RegisterType<EfPackDetailDal>().As<IPackDetailDal>();

            builder.RegisterType<NoteManeger>().As<INoteService>();
            builder.RegisterType<EfNoteDal>().As<INoteDal>();

        }
    }
}
