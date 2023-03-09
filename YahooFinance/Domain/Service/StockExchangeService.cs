using AutoMapper;
using Domain.Dtos.JsonBruto;
using MatthiWare.YahooFinance;
using MatthiWare.YahooFinance.Core.Quote;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using YahooFinance.Domain.Dtos;
using YahooFinance.Domain.Entities;
using YahooFinance.Domain.Interfaces.Repository;
using YahooFinance.Domain.Interfaces.Services;
using static System.Net.WebRequestMethods;


namespace YahooFinance.Domain.Service
{
    public class StockExchangeService : IStockExchangeService
    {
        private readonly IAtivoRepository _AtivoRepository;
        private readonly IAssetVariationRepository _assetVariationRepository;
        private readonly IMapper _mapper;


        public StockExchangeService(IAtivoRepository ativoRepository, IMapper mapper, IAssetVariationRepository assetVariationRepository)
        {
            _AtivoRepository = ativoRepository;
            _mapper = mapper;
            _assetVariationRepository = assetVariationRepository;
        }

        public async Task<object> GetCurrentQuote(string sigla)
        {
            var ativoDto = await BuildAtivo(sigla);

            return ativoDto;
        }


        private async Task<object> BuildAtivo(string sigla)
        {
            var result = await GetDaDosYahoo(sigla, true);

            var listAssetVariation = new List<AssetVariation>();
            var listAssetVariationDto = new List<AssetVariationDto>();
            var jsonRoot = new RootDto();

            if (!string.IsNullOrEmpty(result))
            {
                jsonRoot = JsonConvert.DeserializeObject<RootDto>(result);

                var listPregoes = jsonRoot.Chart.Result.FirstOrDefault().TimeStamps.ToList();

                var listIndicators = jsonRoot.Chart.Result
                                        .First().Indicators.Quote
                                        .SelectMany(x => x.Open).ToArray();

                for (int i = 0; i < listPregoes.Count(); i++)
                {
                    var assetVariation = new AssetVariation();
                    double percentualDiario = 0.0;
                    double percentualDesdePrimeiraData = 0.0;

                    assetVariation.Data = TimeSpanToDateTime(listPregoes[i]);
                    assetVariation.Dia = assetVariation.Data.Day;
                    
                    if (listIndicators[i].ToString() != "" && listIndicators[i].ToString() != "null")
                    {
                        assetVariation.Valor = Math.Round(decimal.Parse(listIndicators[i].ToString()), 2);
                    }

                    double valorAnterior = 0.0;
                    double valorAtual = 0.0;
                    

                    if (i >= 1)
                    {
                        valorAnterior = (double)listAssetVariation[i-1].Valor;
                        valorAtual = (double)assetVariation.Valor;
                        assetVariation.Porcentagem = CalculaPorcentagemDiaria(valorAnterior, valorAtual, percentualDiario);

                        double primeiroValor = (double)listAssetVariation[0].Valor;
                        valorAtual = (double)assetVariation.Valor;
                        percentualDiario = 0.0;

                        assetVariation.PercentualDesdePrimeiraData = CalculaPorcentagemDiaria(valorAnterior, valorAtual, percentualDiario);

                    }

                    listAssetVariation.Add(assetVariation);
                }

                listAssetVariation[0].Porcentagem = 0;
                listAssetVariation[0].PercentualDesdePrimeiraData = 0;

                foreach (var item in listAssetVariation)
                {
                   await _assetVariationRepository.Add(item);
                    listAssetVariationDto.Add(_mapper.Map<AssetVariationDto>(item));
                }
            }

            return listAssetVariationDto;
        }

        private DateTime TimeSpanToDateTime(long duration)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var newDate = origin.AddSeconds(duration).ToString("dd/MM/yyyy");
            return DateTime.Parse(newDate);
        }

        private async Task<string> GetDaDosYahoo(string sigla, bool historic = false)
        {
            HttpClient cliente = new HttpClient();
            string result = string.Empty;

            if (historic)
            {
                result = await cliente.GetStringAsync($"https://query2.finance.yahoo.com/v8/finance/chart/" + sigla + "?metrics=high&interval=1d&range=1mo");
                return result;
            }

            result = await cliente.GetStringAsync($"https://query2.finance.yahoo.com/v8/finance/chart/" + sigla);
            return result;
        }

        private double CalculaPorcentagemDiaria(double valorAnterior, double valorAtual, double percentualDiario)
        {
            while (valorAnterior + ((percentualDiario / 100.0) * valorAnterior) < valorAtual)
            {
                percentualDiario = percentualDiario + 0.1;
            }

            return Math.Round((double)percentualDiario, 2);
        }
    }
}
