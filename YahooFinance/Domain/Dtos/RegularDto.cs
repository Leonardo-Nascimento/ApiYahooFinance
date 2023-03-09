using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YahooFinance.Domain.Dtos
{
    public class RegularDto
    {
        public int? Id { get; set; }

        public string Timezone { get; set; }
        public long End { get; set; }
        public long Start { get; set; }
        public decimal Gmtoffset { get; set; }
    }
}
