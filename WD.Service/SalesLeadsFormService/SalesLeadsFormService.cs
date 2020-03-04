using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WD.Data.Model;
using WD.Repo.Repository;

namespace WD.Service.SalesLeadsFormService
{
    public class SalesLeadsFormService : ISalesLeadsFormService
    {
        private IRepository<salesLeadsForm> _salesLeadsFormRepository;

        public SalesLeadsFormService(IRepository<salesLeadsForm> salesLeadsFormRepository)
        {
            _salesLeadsFormRepository = salesLeadsFormRepository;
        }
        public async Task<int> DeletesalesLeadsForm(int id)
        {
            salesLeadsForm salesLeadsForm = GetsalesLeadsForm(id);
            _salesLeadsFormRepository.Remove(salesLeadsForm);
            return await _salesLeadsFormRepository.SaveChanges();
        }

        public async Task<IEnumerable<salesLeadsForm>> GetSalesLeadsForms()
        {
            return await _salesLeadsFormRepository.GetAll();
        }

        public salesLeadsForm GetsalesLeadsForm(int id)
        {
            return _salesLeadsFormRepository.Get(id);
        }

        public async Task<int> InsertsalesLeadsForm(salesLeadsForm salesLeadsForm)
        {
            return await _salesLeadsFormRepository.Insert(salesLeadsForm);
        }

        public async Task<int> UpdatesalesLeadsForm(salesLeadsForm salesLeadsForm)
        {
            return await _salesLeadsFormRepository.Update(salesLeadsForm);
        }
    }
}
