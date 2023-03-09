using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;
using YahooFinance.Domain.Interfaces.Repository;
using YahooFinance.Domain.Interfaces.Services;

namespace Infra.Repository
{
    public class AtivoRepository : RepositoryBase<Ativo>, IAtivoRepository
    {
        private readonly DbContextOptions<YahooFinanceDbContext> _dbContext;

        public AtivoRepository()
        {
            _dbContext = new DbContextOptions<YahooFinanceDbContext>();
        }

    }
}
