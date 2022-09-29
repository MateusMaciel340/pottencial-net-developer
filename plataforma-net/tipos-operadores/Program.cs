// 4 - Tipos de operadores em c#

/* ---------------------------------------------------------- */

// 4 - [1.1]: Introdução operador de atribuição

/* int a = 10;
int b = 20;

int c = a + b;

Console.WriteLine(c); */

/* ---------------------------------------------------------- */

// 4 - [1.2]: Combinando operadores

/* int a = 10;
int b = 20;

int c = a + b;

c = c + 5; // c = 30 + 5 -> 35
Console.WriteLine(c);

c += 5; // c = 35 + 5 -> 40
Console.WriteLine(c);

c = c - 5; // c = 40 - 5 -> 35
Console.WriteLine(c);

c *= 5; // 35 * 5 -> 175
Console.WriteLine(c); */

/* ---------------------------------------------------------- */

// 4 - [1.3]: Convertendo tipos de variáveis

// Cast - Casting
/* int a = Convert.ToInt32("5");
Console.WriteLine(a);

// Error
int b = int.Parse("5c");
Console.WriteLine(b); */

/* ---------------------------------------------------------- */

// 4 - [1.4]: Diferença entre Convert e Parse

/* int a = Convert.ToInt32(null);
Console.WriteLine(a); // 0 */

/* ---------------------------------------------------------- */

// 4 - [1.5]: Conversão para string

/* int inteiro = 5;
string a = inteiro.ToString();

Console.WriteLine(a); */

/* ---------------------------------------------------------- */

// 4 - [1.6]: Cast implícito

/* int a = 5;
double b = a;

Console.WriteLine(b);

int c = int.MaxValue;
long d = Convert.ToInt32(c);

Console.WriteLine(d);

int e = int.MaxValue;
long f = e;

Console.WriteLine(f); */

/* ---------------------------------------------------------- */

// 4 - [1.7]: Ordem dos operadores

/* double a = 4 / 2 + 2; // 4 / 2 + 2 = 2 + 2 = 4
Console.WriteLine(a);

double b = 4 / (2 + 2);
Console.WriteLine(b); // 4 / (2 + 2) = 4 / 4 = 1 */

/* ---------------------------------------------------------- */

// 4 - [1.8]: Convertendo de maneira segura

/* string a = "15c";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!"); */

/* ---------------------------------------------------------- */

// 4 - [2.2]: Operador condicional na prática

/* int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque!");
} */

/* ---------------------------------------------------------- */

// 4 - [2.4]: IF aninhado

/* int quantidadeEmEstoque = 10;
int quantidadeCompra = 1;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida!");
}
else if(possivelVenda)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque!");
} */

/* ---------------------------------------------------------- */

// 4 - [2.5]: Aprendendo o switch case

/* Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o": 
    case "u":
        Console.WriteLine("Vogal!");
        break;

    default:
        Console.WriteLine("Não é uma vogal!");
        break;
} */

/* ---------------------------------------------------------- */

// 4 - [3.1]: Operador OR na prática

/* bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada!");
} */

/* ---------------------------------------------------------- */

// 4 - [3.4]: Operador AND na prática

/* bool possuiPresencaMinima = true;
double media = 7;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
} */

/* ---------------------------------------------------------- */

// 4 - [3.6]: Operador NOT na prática

/* bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia!");
} */

/* ---------------------------------------------------------- */