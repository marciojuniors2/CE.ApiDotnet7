using CE.ApiDotnet7.Domain.Entities;
using CE.ApiDotnet7.Domain.Interfaces;

namespace CE.ApiDotnet7.Application.Services
{
    public class PurchaseService
    {
        private readonly IGenericRepository<Purchase> _purchaseRepository;

        public PurchaseService(IGenericRepository<Purchase> purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public async Task<IEnumerable<Purchase>> GetAllPurchases()
        {
            return await _purchaseRepository.GetAll();
        }

        public async Task<Purchase> GetPurchaseById(int id)
        {
            return await _purchaseRepository.GetById(id);
        }

        public async Task<Purchase> CreatePurchase(Purchase purchase)
        {
            await _purchaseRepository.Add(purchase);
            return purchase;
        }

        public async Task UpdatePurchase(Purchase purchase)
        {
            await _purchaseRepository.Update(purchase);
        }

        public async Task DeletePurchase(int id)
        {
            var purchase = await _purchaseRepository.GetById(id);
            if (purchase != null)
            {
                await _purchaseRepository.Delete(purchase);
            }
        }
    }
}
