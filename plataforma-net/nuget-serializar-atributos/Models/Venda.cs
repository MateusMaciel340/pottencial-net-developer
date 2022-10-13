using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nuget_serializar_atributos.Models
{
    public class Venda
    {
        // [1.6]: Serialização na prática
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }

        // [1.10]: DateTime em JSON
        public DateTime DataVenda { get; set; }
    }
}