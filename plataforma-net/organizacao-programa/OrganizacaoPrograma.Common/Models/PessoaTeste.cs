using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizacaoPrograma.Common.Models
{
    public class PessoaTeste
    {
        public string? Nome { get; set; }
        public int Idade { get; set; } 

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}. E tenho {Idade} de idade");
        }    
    }

}