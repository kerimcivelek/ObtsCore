using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasMany(I => I.Products).WithOne(I => I.Category).HasForeignKey(I => I.CategoryId);
            builder.HasMany(I => I.OperationDetails).WithOne(I => I.Category).HasForeignKey(I => I.CategoryId);

        }
    }
}
