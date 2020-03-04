using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Mapings;

namespace WD.Repo.DBContext
{
   public class WDContext: DbContext
    {
        public WDContext(DbContextOptions<WDContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SaleLeadsFormMaping());
            modelBuilder.ApplyConfiguration(new SaleFormMapping());
            modelBuilder.ApplyConfiguration(new SalesRepresentativeMapping());

        }
    }
}
