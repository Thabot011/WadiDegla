using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;

namespace WD.Data.Mapings
{
    public class SalesRepresentativeMapping : IEntityTypeConfiguration<SalesRepresentative>
    {
        public void Configure(EntityTypeBuilder<SalesRepresentative> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired();
            builder.HasMany(s => s.SaleForms).WithOne(s => s.SalesRepresentative).IsRequired();
        }
    }
}
