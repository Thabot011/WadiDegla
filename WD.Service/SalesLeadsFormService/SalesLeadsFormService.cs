using System;
using System.Collections.Generic;
using System.Text;
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
        public void DeletesalesLeadsForm(int id)
        {
            salesLeadsForm salesLeadsForm = GetsalesLeadsForm(id);
            _salesLeadsFormRepository.Remove(salesLeadsForm);
            _salesLeadsFormRepository.SaveChanges();
        }

        public IEnumerable<salesLeadsForm> GetSalesLeadsForms()
        {
           return _salesLeadsFormRepository.GetAll();
        }

        public salesLeadsForm GetsalesLeadsForm(int id)
        {
            return _salesLeadsFormRepository.Get(id);
        }

        public void InsertsalesLeadsForm(salesLeadsForm salesLeadsForm)
        {
            _salesLeadsFormRepository.Insert(salesLeadsForm);
        }

        public void UpdatesalesLeadsForm(salesLeadsForm salesLeadsForm)
        {
            _salesLeadsFormRepository.Update(salesLeadsForm);
        }
    }
}
