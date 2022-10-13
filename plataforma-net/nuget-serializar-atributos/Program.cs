using nuget_serializar_atributos.Models;
using Newtonsoft.Json;

// [1.6]: Serialização na prática

/* Venda v1 = new Venda(1, "Material de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(serializado); */

// [1.7]: Escrevendo um arquivo JSON

/* Venda v1 = new Venda(1, "Material de escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivo/vendas.json", serializado);

Console.WriteLine(serializado); */

// [1.8]: Serializando uma coleção

/* List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivo/vendas.json", serializado);

Console.WriteLine(serializado); */

// [1.10]: DateTime em JSON

/* DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivo/vendas.json", serializado);

Console.WriteLine(serializado); */

// [1.11]: Deserializando um objeto

/* string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");

List<VendaNova> listaVenda = JsonConvert.DeserializeObject<List<VendaNova>>(conteudoArquivo);

foreach (VendaNova venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
    $", Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy")}");
} */

// [1.12]: Atributos

string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");

List<VendaNova> listaVenda = JsonConvert.DeserializeObject<List<VendaNova>>(conteudoArquivo);

foreach (VendaNova venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
    $", Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy")}");
}