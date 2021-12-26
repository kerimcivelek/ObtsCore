using DataAccess.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class ObtsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
         optionsBuilder.UseSqlServer("Data Source=.; Database=Obts;uid=sa; pwd=*****;");
          


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OperationMap());
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new OperationTypeMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new OperationDetailMap());
            modelBuilder.ApplyConfiguration(new VehicleBrandMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new PackMap());
            modelBuilder.ApplyConfiguration(new PackDetailMap());
            modelBuilder.ApplyConfiguration(new NoteMap());
            modelBuilder.ApplyConfiguration(new OperationClaimMap());
            modelBuilder.ApplyConfiguration(new UserOperationClaimMap());
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationDetail> OperationDetails { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Pack> Packets { get; set; }
        public DbSet<PackDetail> PackDetails { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
