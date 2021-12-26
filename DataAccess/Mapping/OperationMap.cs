using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class OperationMap : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.FirstKm).IsRequired();
            builder.Property(I => I.LastKm).IsRequired();
            builder.Property(I => I.PeriodKm).IsRequired();
            builder.Property(I => I.Note).HasColumnType("ntext");

            builder.HasMany(I => I.OperationDetails).WithOne(I => I.Operation).HasForeignKey(I => I.OperationId);
        }
    }
}
