using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Domain.Dtos
{
    public class IndicatorsDto
    {
        public int? Id { get; set; }
        public IEnumerable <QuoteDto> Quote { get; set; }
    }
}
