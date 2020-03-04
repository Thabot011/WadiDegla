using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;
using WD.Repo.Repository;

namespace WD.Service.SaleFromService
{
    public class SaleFromService : ISaleFromService
    {
        private IRepository<SaleForm> _saleFormRepository;

        public SaleFromService(IRepository<SaleForm> saleFormRepository)
        {
            _saleFormRepository = saleFormRepository;
        }


        public void DeleteSaleForm(int id)
        {
            SaleForm saleForm = GetSaleForm(id);
            _saleFormRepository.Remove(saleForm);
            _saleFormRepository.SaveChanges();
        }

        public IEnumerable<SaleForm> GetSaleForms()
        {
            return _saleFormRepository.GetAll();
        }

        public SaleForm GetSaleForm(int id)
        {
            return _saleFormRepository.Get(id);
        }

        public void InsertSaleForm(SaleForm SaleForm)
        {
            _saleFormRepository.Insert(SaleForm);
        }

        public void UpdateSaleForm(SaleForm SaleForm)
        {
            _saleFormRepository.Update(SaleForm);
        }
    }
}
