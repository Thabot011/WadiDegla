using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;

namespace WD.Data.Mapings
{
    public class SaleLeadsFormMaping : IEntityTypeConfiguration<salesLeadsForm>
    {
        public void Configure(EntityTypeBuilder<salesLeadsForm> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.CustomerName).IsRequired();
            builder.Property(s => s.Telphone).IsRequired();
            builder.Property(s => s.Adress).IsRequired();
            builder.Property(s => s.DateOfVisit).IsRequired();
            builder.Property(s => s.CarModel).IsRequired();
            builder.Property(s => s.TouchPoint).IsRequired();
        }
    }
}
