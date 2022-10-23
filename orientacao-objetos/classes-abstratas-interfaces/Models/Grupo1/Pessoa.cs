using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Models.Grupo1
{
    public class Pessoa
    {
        // [1.3]: Construtor por herança
        public Pessoa()
        {
            
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}