using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca_polimorfismo.Models
{
    public class Pessoa
    {
        // [1.2]: Herança na prática
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        // Polimorfismo em tempo de execução

        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}