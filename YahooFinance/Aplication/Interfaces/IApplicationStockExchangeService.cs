using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Aplication.Dtos;

namespace Aplication.Interfaces
{
    public interface IApplicationStockExchangeService
    {
        Task Add(AtivoDto obj);
        Task Update(AtivoDto obj);
        Task Delete(AtivoDto obj);
        Task<AtivoDto> GetById(int id);
        Task<IEnumerable<AtivoDto>> GetAll();
    }
}
