using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Models.Grupo1
{
    // [1.4]: Classe selada na prática
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
    }
}