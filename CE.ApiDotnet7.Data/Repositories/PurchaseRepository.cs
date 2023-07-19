using CE.ApiDotnet7.Domain.Entities;
using CE.ApiDotnet7.Domain.Interfaces;
using CE.ApiDotnet7.Infra.Data.Context;

namespace CE.ApiDotnet7.Infra.Data.Repositories
{
    public class PurchaseRepository : GenericRepository<Purchase>, IGenericRepository<Purchase>
    {
        public PurchaseRepository(CeContext dbContext) : base(dbContext)
        {
        }
    }
}
