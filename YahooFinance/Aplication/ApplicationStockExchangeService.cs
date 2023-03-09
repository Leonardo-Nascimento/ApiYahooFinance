using Aplication.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Aplication.Dtos;
using YahooFinance.Domain.Entities;
using YahooFinance.Domain.Interfaces.Services;

namespace Aplication
{
    public class ApplicationStockExchangeService : IApplicationStockExchangeService
    {
        private readonly IStockExchangeService _stockExchangeService;
        private readonly IMapper _mapper;

        public ApplicationStockExchangeService(IMapper mapper, IStockExchangeService stockExchangeService)
        {
            _mapper = mapper;
            _stockExchangeService = stockExchangeService;
        }

        public async Task Add(AtivoDto obj)
        {
            var ativo = _mapper.Map<Ativo>(obj);
            await _stockExchangeService.Add(ativo);
        }

        public Task Delete(AtivoDto obj)
        {
            return null;
        }

        public Task<IEnumerable<AtivoDto>> GetAll()
        {
            return null;
        }

        public Task<AtivoDto> GetById(int id)
        {
            return null;
        }

        public Task Update(AtivoDto obj)
        {
            return null;
        }
    }
}
