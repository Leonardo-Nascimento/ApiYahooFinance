using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.JsonBruto
{
    [Serializable]
    public class RootDto
    {
        [JsonProperty(PropertyName = "chart")]
        public ChartDto Chart { get; set; }

    }
}
