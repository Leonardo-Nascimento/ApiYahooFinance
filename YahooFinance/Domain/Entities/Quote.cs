using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Domain.Entities
{
    public class Quote : BaseEntity
    {
        public double Close { get; set; }
        public double Open { get; set; }
        public int Volume { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public Indicators Indicators { get; set; }
    }
}
