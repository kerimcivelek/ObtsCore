using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class OperationDetailMap : IEntityTypeConfiguration<OperationDetail>
    {
        public void Configure(EntityTypeBuilder<OperationDetail> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Price).IsRequired();
            builder.Property(I => I.Note).HasColumnType("ntext");
        }
    }
}
