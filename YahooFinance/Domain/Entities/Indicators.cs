using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Entities
{
    public class Indicators : BaseEntity
    {
        public List<Quote> Quote { get; set; }
    }
}
