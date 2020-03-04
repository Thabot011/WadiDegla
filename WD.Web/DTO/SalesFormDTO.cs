using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WD.Data.Model;

namespace WD.Web.DTO
{
    public class SalesFormDTO
    {
        public string CustomerName { get; set; }
        public SalesRepresentativeDTO SalesRepresentative { get; set; }
        public CarModel CarModel { get; set; }
        public TouchPoint TouchPoint { get; set; }
    }
}
