using Newtonsoft.Json;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Dtos
{
    [Serializable]
    public class AtivoFullDto
    {
        [JsonProperty(PropertyName = "meta")]
        public AtivoDto Ativo { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public IEnumerable<long> TimeStamps { get; set; }

        [JsonProperty(PropertyName = "indicators")]
        public IndicatorsDto Indicators { get; set; }

    }
}
