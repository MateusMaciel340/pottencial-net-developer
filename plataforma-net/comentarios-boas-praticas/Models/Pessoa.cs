using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comentarios_boas_praticas.Models
{
    // 9 - [1.4]: Comentando nossas classes
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        // 9 - [1.5]: Comentários nos métodos

        /// <summary>
        /// Faz a pessoa se apresentar
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. E tenho {Idade} de idade!");
        }
    }
}