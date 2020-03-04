using System;
using System.Collections.Generic;
using System.Text;

namespace WD.Data.Model
{
   public class SaleForm:BaseEntity
    {
        public string CustomerName { get; set; }
        public SalesRepresentative SalesRepresentative { get; set; }
        public CarModel CarModel { get; set; }
        public TouchPoint TouchPoint { get; set; }
    }
}
