using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao_abstracao_encapsulamento.Models
{
    public class ContaCorrente
    {
        // [1.7]: Encapsulamento na prática
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo { get; set; }

        public void Sacar(decimal valor)
        {
            if (saldo >= valor) 
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + saldo);
        }
    }
}