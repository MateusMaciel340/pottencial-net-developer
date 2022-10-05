using manipulando_valores.Models;

using System.Globalization;

// [1.2]: Concatenando String

/* Pessoa pessoa = new Pessoa("Mateus", "Maciel");

Pessoa pessoa1 = new Pessoa(nome: "Marcelo", sobrenome: "Nunes Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa);
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.ListarAlunos();  */

// [1.5]: Concatenação de valores

/* string numero1 = "10";
int numero2 = 20;

string resultado = numero1 + numero2;

Console.WriteLine(resultado); */

// [1.6]: Formatando valores monetários

/* decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:C}"); */

// [1.7]: Alterando a localização do código

/* CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 8267.40M;

Console.WriteLine($"{valorMonetario:C}"); */

// [1.8]: Alterando a localização da cultura

/* CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 8267.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); */

// [1.9]: Formatação personalizada

/* CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 8267.40M;

Console.WriteLine(valorMonetario.ToString("N2")); */

// [1.10]: Representando porcentagem

/* double porcetagem = .3421;

Console.WriteLine(porcetagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));*/

// [1.11]: Formatando o tipo DateTime

/* DateTime data = DateTime.Now;

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToString("dd/M/yyyy HH:mm"));
Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm"));
Console.WriteLine(data.ToString("dd-MM-yyyy hh:mm"));
Console.WriteLine(data.ToString("hh:mm dd-MM-yyyy ")); */

// [1.12]: Formatando data e hora

/* DateTime data = DateTime.Now;

DateTime dataConvercao = DateTime.Parse("01/10/2022 15:18");
dataConvercao = DateTime.Parse("32/10/2022 15:18"); // Error!

Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

Console.WriteLine(dataConvercao); */

// [1.13]: DateTime com TryParse

/* string dataString = "2022-10-05 15:21";

DateTime.TryParseExact(
    dataString, "yyyy-MM-dd HH:mm", 
    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

//DateTime data = DateTime.Parse(dataString);

Console.WriteLine(data); */

// [1.14]: Validando o retorno do TryParse

string dataString = "2022-10-05 15:21";

bool sucesso = DateTime.TryParseExact(
    dataString, "yyyy-MM-dd HH:mm", 
    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso - Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida!");
}

Console.WriteLine(data);