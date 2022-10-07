using tuplas_ternario_desconstrucao_objeto.Models;

// [1.2]: Tuplas na prática

/* (int, string, string, decimal) tupla = (1, "Mateus", "Maciel", 1.80M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}"); */

// [1.3]: Outra sintaxe da tupla

/* (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Mateus", "Maciel", 1.80M);
ValueTuple<int, string, string, decimal> outroExemplo = (1, "Mateus", "Maciel", 1.80M);
var outroExemploTuplaCreate = Tuple.Create(1, "Mateus", "Maciel", 1.80M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}"); */

// [1.5]: Testando nosso método

/* LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo!");
} */

// [1.6]: Descartes

/* LeituraArquivo arquivo = new LeituraArquivo();

// _ -> descartar
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo!");
} */

// [1.7]: Desconstrutor

/* Pessoa p1 = new Pessoa("Mateus", "Maciel");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}"); */

// [1.8]: IF Ternário

int numero = 15;
bool ehPar = false;

// IF Ternário

ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// IF Comum

/* if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par!");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar!");
} */