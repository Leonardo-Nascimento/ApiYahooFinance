using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Entities
{
    public class Ativo : BaseEntity
    {
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public string ExchangeName { get; set; }
        public string InstrumentType { get; set; }
        public DateTime FirstTradeDate { get; set; }
        public DateTime RegularMarketTime { get; set; }
        public decimal Gmtoffset { get; set; }
        public string Timezone { get; set; }
        public string ExchangeTimezoneName { get; set; }
        public double RegularMarketPrice { get; set; }
        public double ChartPreviousClose { get; set; }
        public double PreviousClose { get; set; }
        public int Scale { get; set; }
        public int PriceHint { get; set; }
        public int CurrentTradingPeriodId { get; set; }
        public CurrentTradingPeriod CurrentTradingPeriod { get; set; }
        public IEnumerable<TradingPeriod> TradingPeriods { get; set; }
        public string DataGranularity { get; set; }
        public string Range { get; set; }        
        public IEnumerable<ValidRanges> ValidRanges { get; set; }
    }
}
