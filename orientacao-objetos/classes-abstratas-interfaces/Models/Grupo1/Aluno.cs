using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Models.Grupo1
{
    public class Aluno : Pessoa
    {
        // [1.3]: Construtor por herança
        public Aluno()
        {
            
        }

        public Aluno(string nome) : base(nome)
        {

        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}