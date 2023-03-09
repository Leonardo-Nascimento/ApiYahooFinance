using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Entities;

namespace YahooFinance.Domain.Entities
{
    public class AtivoFull : BaseEntity
    {
        public Ativo Ativo{ get; set; }        
        public Indicators Indicators { get; set; }
    }
}
