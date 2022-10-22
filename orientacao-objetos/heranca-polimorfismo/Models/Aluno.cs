using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca_polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        // [1.2]: Herança na prática
        public double Nota { get; set; }

        // [1.5]: Polimorfismo em tempo de execução
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno de nota {Nota}");
        }
    }
}