using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Entities
{
    [Serializable]
    public class CurrentTradingPeriod : BaseEntity
    {
        public int PreId { get; set; }

        [JsonProperty(PropertyName = "pre")] 
        public Pre Pre { get; set; }

        public int RegularId { get; set; }

        [JsonProperty(PropertyName = "regular")]
        public Regular Regular { get; set; }

        public int PostId { get; set; }
        
        [JsonProperty(PropertyName = "post")]
        public Post Post { get; set; }
    }
}
