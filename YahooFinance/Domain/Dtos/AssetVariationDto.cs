using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinance.Domain.Dtos
{
    public class AssetVariationDto
    {
        public int? Id { get; set; }
        public int Dia { get; set; }
        public DateTime Data { get; set; }        
        public decimal Valor { get ; set; }
        public double Porcentagem { get; set; }
        public double PercentualDesdePrimeiraData { get; set; }
    }
}
