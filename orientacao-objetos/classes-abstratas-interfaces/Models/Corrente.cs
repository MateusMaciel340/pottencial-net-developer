using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_abstratas_interfaces.Models
{
    public class Corrente : Conta
    {
        // [1.1]: Classe abstrata na prática
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}