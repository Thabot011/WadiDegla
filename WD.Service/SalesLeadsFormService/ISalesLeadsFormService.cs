using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WD.Data.Model;

namespace WD.Service.SalesLeadsFormService
{
   public interface ISalesLeadsFormService
    {
        Task<IEnumerable<salesLeadsForm>> GetSalesLeadsForms();
        salesLeadsForm GetsalesLeadsForm(int id);
        Task<int> InsertsalesLeadsForm(salesLeadsForm salesLeadsForm);
        Task<int> UpdatesalesLeadsForm(salesLeadsForm salesLeadsForm);
        Task<int> DeletesalesLeadsForm(int id);
    }
}
