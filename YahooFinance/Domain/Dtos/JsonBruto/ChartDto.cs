using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Dtos;

namespace Domain.Dtos.JsonBruto
{
    [Serializable]
    public class ChartDto
    {
        [JsonProperty(PropertyName = "result")]
        public IEnumerable<AtivoFullDto> Result { get; set; }
        public object error { get; set; }
    }
}
