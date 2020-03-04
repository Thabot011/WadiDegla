using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;

namespace WD.Service.SalesLeadsFormService
{
   public interface ISalesLeadsFormService
    {
        IEnumerable<salesLeadsForm> GetSalesLeadsForms();
        salesLeadsForm GetsalesLeadsForm(int id);
        void InsertsalesLeadsForm(salesLeadsForm salesLeadsForm);
        void UpdatesalesLeadsForm(salesLeadsForm salesLeadsForm);
        void DeletesalesLeadsForm(int id);
    }
}
