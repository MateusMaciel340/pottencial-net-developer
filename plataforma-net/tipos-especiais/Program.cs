// [1.2]: Tipos nulos na prática

/* bool? desejaReceberEmail = true;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber o e-mail!");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber o e-mail!");
} */

// [1.3]: Tipos nulos em propriedades

using tipos_especiais.Models;
using Newtonsoft.Json;

/* string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");

List<VendaNova> listaVenda = JsonConvert.DeserializeObject<List<VendaNova>>(conteudoArquivo);

foreach (VendaNova venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id} - Produto: {venda.Produto}" +
    $" - Preço: {venda.Preco} - Data: {venda.DataVenda.ToString("dd/MM/yyyy")}" +
    $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
} */

// [1.4]: Tipos anônimos

/* var tipoAnonimo = new { Nome = "Mateus", Sobrenome = "Maciel", Altura = 1.80 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);
 */

// [1.5]: Tipos anônimos em coleção

/* string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");

List<VendaNova> listaVenda = JsonConvert.DeserializeObject<List<VendaNova>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto} - Preço: {venda.Preco}");
} */

// [1.6]: Tipo dinâmico 

/* dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}" + 
    $" - Valor: {variavelDinamica}");

variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}" + 
    $" - Valor: {variavelDinamica}");

variavelDinamica = true;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}" + 
    $" - Valor: {variavelDinamica}"); */

// [1.8]: Testando nossa classe genérica

/* MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]); */

/* MeuArray<string> arrayInteiro = new MeuArray<string>();

arrayInteiro.AdicionarElementoArray("Teste");

Console.WriteLine(arrayInteiro[0]);

List<int> lista = new List<int>(); */

// [1.9]: Métodos de extensão

/* int numero = 21;
bool par = false;

par = numero % 2 == 0;

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem); */

int numero = 12;
bool par = false;

int valor = 1;
valor.EhPar();

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem);