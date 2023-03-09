

using YahooFinance.Domain.Dtos;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Interfaces.Services
{
    public interface IStockExchangeService
    {
        Task<object> GetCurrentQuote(string sigla);
        

    }
}
