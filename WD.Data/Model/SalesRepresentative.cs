using System;
using System.Collections.Generic;
using System.Text;

namespace WD.Data.Model
{
    public class SalesRepresentative : BaseEntity
    {
        public SalesRepresentative()
        {
            SaleForms = new HashSet<SaleForm>();
        }
        public string Name { get; set; }
        public ICollection<SaleForm> SaleForms { get; set; }

    }
}
