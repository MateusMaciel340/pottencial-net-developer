/* ------------------------------------- */

// 5 - [1.2]: Introdução ao FOR

/* int numero = 5;

//Console.WriteLine($"{numero} * 1 = {numero * 1}");

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
} */

/* ------------------------------------- */

// 5 - [1.4]: Introdução ao While
//     [1.5]: Interrompendo o fluxo de execução

/* int numero = 5;
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 6)
    {
        break;
    }
} */

/* ------------------------------------- */

// 5 - [1.6]: Introdução ao DO WHILE

/* int soma = 0, numero = 0;

do 
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;


} while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}"); */

/* ------------------------------------- */

// 5 - [1.8]: Construindo um menu interativo
//     [1.9]: Refatorando o menu

string? opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            // Environment.Exit(0);
            break;

        default: 
            Console.WriteLine("Opção inválida!");
            break;

    }
}

Console.WriteLine("O programa se encerrou!");

/* ------------------------------------- */