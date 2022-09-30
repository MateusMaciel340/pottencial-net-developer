using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comentarios_boas_praticas.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar </param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// Realiza uma subtração de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para subtrair</param>
        /// <param name="y">O segundo número inteiro para subtrair </param>
        /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            return x - y;
        }
    }
}