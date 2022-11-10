// [1.1] - Elemento Majoritário

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));

    }

    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                major = nums[i];
                count++;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return major;
    }
}

// [1.2] Aumento de salário

class minhaClasse { 

    static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 

    salario = Convert.ToDouble(Console.ReadLine()); 

    if(salario < 0) { 
        return; 

    } else if (salario <= 400.00d) { 
        percentual = 0.15d;
        reajuste =  percentual * salario;
        novoSalario =   salario + reajuste;


    } else if (salario <= 800.00d) { 
        percentual = 0.12d;
        reajuste = percentual * salario;
        novoSalario = salario + reajuste;

    } else if (salario <= 1200.00d) { 
        percentual = 0.10d;
        reajuste = percentual * salario;
        novoSalario = salario + reajuste;

    } else if (salario <= 2000.00d) { 
        percentual = 0.07d;
        reajuste = percentual * salario;
        novoSalario = salario + reajuste;

    } else { 
        percentual = 0.04d;
        reajuste = percentual * salario;
        novoSalario = salario + reajuste;

    } 

    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
    Console.WriteLine("Em percentual: {0} %", percentual * 100);

    } 
}

// [1.3]: A Corrida de Tartarugas

class Desafio
{
    public static void Main()
    {
        int quantidadeEntradas = 3;

        while (quantidadeEntradas > 0)
        {
            var numeroQuantidade = Int32.Parse(Console.ReadLine());

            if (numeroQuantidade >= 1 && numeroQuantidade <= 500)
            {
                string[] tartarugas = Console.ReadLine().Split(" ");
                var maiorVelocidade = Int32.Parse(tartarugas[0]);

                for (int i = 0; i < tartarugas.Length; i++)
                {
                    var tartaruga = Int32.Parse(tartarugas[i]);

                    if (maiorVelocidade < tartaruga)
                    {
                        maiorVelocidade = tartaruga;
                    }
                }

                if (maiorVelocidade < 10)
                {
                    Console.WriteLine(1);
                }
                else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
                {
                    Console.WriteLine(2);
                }
                else if (maiorVelocidade >= 20)
                {
                    Console.WriteLine(3);
                }
                quantidadeEntradas--;
            }
            else
            {
                Console.WriteLine("Insira um número entre 1 e 500");
            }
        }
    }
}
