using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// [1.12]: Atributos
using Newtonsoft.Json;

namespace nuget_serializar_atributos.Models
{
    public class VendaNova
    {
        // [1.11]: Deserializando um objeto
        public int Id { get; set; }
        
        // [1.12]: Atributos
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        
        public decimal Preco { get; set; }

        public DateTime DataVenda { get; set; }
    }
}