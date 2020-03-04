using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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


        public async Task<int> DeleteSaleForm(int id)
        {
            SaleForm saleForm = GetSaleForm(id);
            _saleFormRepository.Remove(saleForm);
            return await _saleFormRepository.SaveChanges();
        }

        public async Task<IEnumerable<SaleForm>> GetSaleForms()
        {
            return await _saleFormRepository.GetAll();
        }

        public SaleForm GetSaleForm(int id)
        {
            return _saleFormRepository.Get(id);
        }

        public async Task<int> InsertSaleForm(SaleForm SaleForm)
        {
            return await _saleFormRepository.Insert(SaleForm);
        }

        public async Task<int> UpdateSaleForm(SaleForm SaleForm)
        {
            return await _saleFormRepository.Update(SaleForm);
        }
    }
}
