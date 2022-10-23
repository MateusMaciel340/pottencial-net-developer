using classes_abstratas_interfaces.Interfaces;
using classes_abstratas_interfaces.Models;
using classes_abstratas_interfaces.Models.Grupo1;
using classes_abstratas_interfaces.Models.Grupo2;
using classes_abstratas_interfaces.Models.Grupo3;

/* 
// [1.1]: Classe abstrata na prática

Corrente corrente = new Corrente();
corrente.Creditar(500);
corrente.ExibirSaldo(); */

// [1.3]: Construtor por herança

/* Pessoa pessoa = new Pessoa("Mateus");
Aluno aluno = new Aluno("João");
aluno.Apresentar();

Professor professor = new Professor(); */

// [1.4]: Classe selada na prática

// [1.8]: Classe object na prática

/* Computador computador = new Computador();
Console.WriteLine(computador.ToString()); */

// [1.10]: Interface na prática

ICalculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Multiplicar(3, 9));