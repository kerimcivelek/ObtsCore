using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(I => I.LastName).HasMaxLength(30).IsRequired();
            builder.Property(I => I.UserName).HasMaxLength(30).IsRequired();

            //builder.HasMany(I => I.Customers).WithOne(I => I.User).HasForeignKey(I => I.UserId).OnDelete(DeleteBehavior.SetNull);
            //builder.HasMany(I => I.Operations).WithOne(I => I.User).HasForeignKey(I => I.UserId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
