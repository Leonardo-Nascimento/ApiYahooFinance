using Infra.Context;
using Microsoft.EntityFrameworkCore;
using YahooFinance.Domain.Entities;
using YahooFinance.Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class AssetVariationRepository : RepositoryBase<AssetVariation>, IAssetVariationRepository
    {
        private readonly DbContextOptions<YahooFinanceDbContext> _dbContext;

        public AssetVariationRepository()
        {
            _dbContext = new DbContextOptions<YahooFinanceDbContext>();
        }
    }
}
