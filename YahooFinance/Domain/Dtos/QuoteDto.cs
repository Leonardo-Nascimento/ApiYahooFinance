using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Domain.Dtos
{ 
    public class QuoteDto
    {
        public int? Id { get; set; }

        public IEnumerable<object> Close { get; set; }
        public IEnumerable<object> Open { get; set; }
        public IEnumerable<object> Volume { get; set; }
        public IEnumerable<object> Low { get; set; }
        public IEnumerable<object> High { get; set; }
    }
}
