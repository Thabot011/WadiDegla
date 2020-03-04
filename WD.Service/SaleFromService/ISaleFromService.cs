using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WD.Data.Model;

namespace WD.Service.SaleFromService
{
   public interface ISaleFromService
    {
        Task<IEnumerable<SaleForm>> GetSaleForms();
        SaleForm GetSaleForm(int id);
        Task<int> InsertSaleForm(SaleForm SaleForm);
        Task<int> UpdateSaleForm(SaleForm SaleForm);
        Task<int> DeleteSaleForm(int id);
    }
}
