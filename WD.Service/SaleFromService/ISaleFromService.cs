using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;

namespace WD.Service.SaleFromService
{
   public interface ISaleFromService
    {
        IEnumerable<SaleForm> GetSaleForms();
        SaleForm GetSaleForm(int id);
        void InsertSaleForm(SaleForm SaleForm);
        void UpdateSaleForm(SaleForm SaleForm);
        void DeleteSaleForm(int id);
    }
}
