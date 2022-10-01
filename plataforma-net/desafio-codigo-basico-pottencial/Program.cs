// [01] - Somar todos os digítos

int numero;
int digito;
int soma = 0;

Console.WriteLine("Informe o número: ");
numero = Convert.ToInt32(Console.ReadLine());

while (numero > 0)
{
    digito = numero % 10;
    soma = soma + digito;
    numero = numero / 10;
}

Console.WriteLine("Soma = " + soma);
Console.ReadKey();

// [02] - Encaixa ou não encaixa

Console.WriteLine("Digite a quantidade: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

string[] valores = new string[2];

for (int contador = 0; contador < quantidade; contador++)
{
    valores = Console.ReadLine().Split(" ");

    string valorA = valores[0];
    string valorB = valores[1];

    if (valorB.Length > valorA.Length)
    {
        Console.WriteLine("Não encaixa!");
    }
    else if (valorA.EndsWith(valorB))
    {
        Console.WriteLine("Encaixa!");
    }
    else
    {
        Console.WriteLine("Não encaixa!");
    }
}

// [03] - Pegar os três divisores positivos, e retornar true ou false.

Console.WriteLine("Informe um número:");
int numero1 = Convert.ToInt32(Console.ReadLine());

int contar = 0;

for (int contador = 1; contador <= numero1; contador++)
{
    if (numero1 % contador == 0)
    {
        contar++;
    }

    if (contar > contador)
    {
        Console.WriteLine(false);
    }
}

Console.WriteLine(contar == 3);