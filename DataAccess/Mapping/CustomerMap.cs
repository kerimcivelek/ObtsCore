using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Name).IsRequired();
            builder.Property(I => I.Plaka).HasMaxLength(15).IsRequired();
            builder.Property(I => I.Brand).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Gsm).HasMaxLength(11).IsRequired();
            builder.Property(I => I.Note).HasColumnType("ntext");
            //builder.HasMany(I => I.Operations).WithOne(I => I.Customer).HasForeignKey(I => I.CustomerId);
        }
    }
}
