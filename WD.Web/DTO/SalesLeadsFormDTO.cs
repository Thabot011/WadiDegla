using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WD.Data.Model;

namespace WD.Web.DTO
{
    public class SalesLeadsFormDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(150)]
        [MinLength(2)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(11), MinLength(11)]
        public int Telphone { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfVisit { get; set; }
        [Required]
        public CarModel CarModel { get; set; }
        [Required]
        public TouchPoint TouchPoint { get; set; }
    }
}
