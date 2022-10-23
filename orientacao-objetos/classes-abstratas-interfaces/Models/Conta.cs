using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Models
{
    public abstract class Conta
    {
        // [1.1]: Classe abstrata na prática
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}