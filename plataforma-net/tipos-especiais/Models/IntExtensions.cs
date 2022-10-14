using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especiais.Models
{
    public static class IntExtensions
    {
        // [1.9]: Métodos de extensão
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}