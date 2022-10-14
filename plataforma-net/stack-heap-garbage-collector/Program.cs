// [1.1]: Introdução tipos de memória

/*
 * Vamos entender os dois tipos de memória existente no C#,
 * tipos de valores e tipos de referência.
*/

// [1.2]: Entendendo a Stack e Heap

/*
 * Declaração de variável
 * Stack e Heap
 */

// Exemplo

/*
 * Stack: forma otimizada para organizar dados na memória 
 * alocados em sequência
 * 
 * Heap: é a organização de memória mais flexível
 * que permite o uso de qualquer área lógica disponível.
 */

/* void Metodo()
{
    // stack (a, b e p1 (ref))
    int a = 5; 
    int b = 10;

    // heap (p1 objeto)
    Pessoa p1 = new Pessoa();
} */

// [1.3]: Limpeza de memória

/* void Metodo()
{
    // stack (a, b e p1 (ref))
    int a = 5; 
    int b = 10;

    // heap (p1 objeto)
    Pessoa p1 = new Pessoa();
} */

/*
 * Gargabe Collector: limpará os dados da memória heap que estão
 * sem referência que estão em uma variável em uso.
*/

// [1.4]: Tipos de valor e referência

/*
 * Tipo de valor: Uma variável de um tipo de valor contém uma instância
 * do tipo.
 * 
 * Tipo de referência: Uma variável de um tipo de referência contém
 * uma referência a uma instância do tipo.
*/

// Tipos de referência (p1 (ref) - p1 objeto) -> (stack + heap) + complexo

// Tipos de valor (a, b) -> (stack) simples

// [1.5]: Atribuições de tipos

/* void Metodo()
{
    // stack (a, b) / sem heap
    int a = 5; 

    int b = 10;
} */

// Tipos de referência

/* void Metodo()
{
    Pessoa p1 = new Pessoa("Mateus", "Maciel"); (p1 ref) -> stack

    Pessoa.p2 = p1; (p2 ref) -> stack
    p2.Nome = "Mateus;

    // Pessoa (objeto) -> heap
}
 */

using stack_heap_garbage_collector.Models;

// [1.6]: Atribuindo tipo de referência

Pessoa p1 = new Pessoa(nome: "Mateus", sobrenome: "Maciel");

Pessoa p2 = p1;
p2.Nome = "Marcos";

Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");

Console.WriteLine("------------------------------------------");

// [1.7]: Atribuindo tipo de valor

int a = 10;
int b = a;

b = 60;

Console.WriteLine($"O valor de A: {a}");
Console.WriteLine($"O valor de B: {b}");