using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.HasMany(I => I.Customers).WithOne(I => I.Company).HasForeignKey(I => I.CompanyId);

            builder.HasMany(I => I.Categories).WithOne(I => I.Company).HasForeignKey(I => I.CompanyId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
