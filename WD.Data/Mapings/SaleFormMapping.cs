using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;

namespace WD.Data.Mapings
{
    public class SaleFormMapping : IEntityTypeConfiguration<SaleForm>
    {
        public void Configure(EntityTypeBuilder<SaleForm> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.CustomerName).IsRequired();
            builder.Property(s => s.CarModel).IsRequired();
            builder.Property(s => s.TouchPoint).IsRequired();
            builder.HasOne(s => s.SalesRepresentative).WithMany(s => s.SaleForms).IsRequired();
        }
    }
}
