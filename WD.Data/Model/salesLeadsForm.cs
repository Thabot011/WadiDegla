using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WD.Data.Model
{
    public class salesLeadsForm : BaseEntity
    {
        [StringLength(50, MinimumLength = 2)]
        public string CustomerName { get; set; }
        [StringLength(150, MinimumLength = 5)]
        public string Adress { get; set; }
        [MaxLength(11),MinLength(11)]
        public int Telphone { get; set; }
        public DateTime DateOfVisit { get; set; }
        public CarModel CarModel { get; set; }
        public TouchPoint TouchPoint { get; set; }
    }

    public enum CarModel
    {
        Mercedes = 1,
        BMW = 2,
        Audi = 3,
        Hundai = 4,
        BYD = 5,
        KIA = 6,
        Chevorlet = 7
    }

    public enum TouchPoint
    {
        Newspaper = 1,
        Web = 2,
        WordOfMouth = 3
    }
}
