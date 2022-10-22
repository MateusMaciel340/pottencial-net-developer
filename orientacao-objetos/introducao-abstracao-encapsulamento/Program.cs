using introducao_abstracao_encapsulamento.Models;

// [1.5]: Abstração na prática

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Mateus";
pessoa.Idade = 21;
pessoa.Apresentar();

Console.WriteLine("----------------------------");

// [1.7]: Encapsulamento na prática

ContaCorrente contaCorrente = new ContaCorrente(123, 1000);

//contaCorrente.saldo = 5;
contaCorrente.ExibirSaldo();
contaCorrente.Sacar(500);
contaCorrente.ExibirSaldo();