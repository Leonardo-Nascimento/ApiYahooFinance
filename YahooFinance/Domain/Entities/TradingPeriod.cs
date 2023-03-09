using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;

namespace Domain.Entities
{
    public class TradingPeriod :BaseEntity
    {        
        public string Timezone { get; set; }
        public long End { get; set; }
        public long Start { get; set; }
        public decimal Gmtoffset { get; set; }        
    }
}
