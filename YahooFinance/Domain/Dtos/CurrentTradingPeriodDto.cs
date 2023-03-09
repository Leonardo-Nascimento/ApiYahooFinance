using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Domain.Dtos
{
    [Serializable]
    public class CurrentTradingPeriodDto
    {
        public int? Id { get; set; }
        public int? PreId { get; set; }

        [JsonProperty(PropertyName = "pre")]
        public PreDto Pre { get; set; }
        public int? RegularId { get; set; }

        [JsonProperty(PropertyName = "regular")]
        public RegularDto Regular { get; set; }
        public int? PostId { get; set; }

        [JsonProperty(PropertyName = "post")]
        public PostDto Post { get; set; }
    }
}
