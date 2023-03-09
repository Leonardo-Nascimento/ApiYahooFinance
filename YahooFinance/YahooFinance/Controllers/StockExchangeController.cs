using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YahooFinance.Domain.Interfaces.Services;

namespace YahooFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockExchangeController : Controller
    {
        private readonly IStockExchangeService _stockExchangeService;
        private readonly IMapper _mapper;

        public StockExchangeController(IStockExchangeService stockExchangeService, IMapper mapper)
        {
            _stockExchangeService = stockExchangeService;
            _mapper = mapper;
        }


        [HttpGet("GetCurrentQuote/{sigla}")]
        public async Task<object> GetCurrentQuote(string sigla)
        {
            sigla = sigla.ToUpper() + ".SA";

            var result = await _stockExchangeService.GetCurrentQuote(sigla);

            if (result != null)
                return result;

            return NotFound();

        }


    }
}
