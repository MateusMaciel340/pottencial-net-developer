using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Models.Grupo1
{
    // [1.4]: Classe selada na prática
    public class Professor : Pessoa // sealed
    {
        // [1.3]: Construtor por herança
        public Professor()
        {

        }

        public Professor(string nome) : base(nome)
        {

        }

        public decimal Salario { get; set; }

        // [1.4]: Classe selada na prática
        public override void Apresentar() // sealed
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario} reais");
        }
    }
}