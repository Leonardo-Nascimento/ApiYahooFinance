using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Entities
{
    public class Pre : BaseEntity
    {
        public string Timezone { get; set; }
        public int End { get; set; }
        public int Start { get; set; }
        public int Gmtoffset { get; set; }
    }
}
