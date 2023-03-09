using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Domain.Entities
{
    public class AssetVariation : BaseEntity
    {
        public int Dia { get; set; }
        public DateTime Data { get; set; }        
        
        public decimal Valor { get; set; }
        public double Porcentagem { get; set; }
        public double PercentualDesdePrimeiraData { get; set; }
    }
}
