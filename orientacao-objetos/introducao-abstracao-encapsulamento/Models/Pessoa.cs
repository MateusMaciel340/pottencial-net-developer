using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao_abstracao_encapsulamento.Models
{
    public class Pessoa
    {
        // [1.5]: Abstração na prática
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade} anos");
        }
    }
}