using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Interfaces
{
    // [1.10]: Interface na prática
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        /* int Dividir(int num1, int num2); */

        // [1.11]: Método padrão na interface
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}