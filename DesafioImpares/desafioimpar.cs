using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite quantos números ímpares entre 100 e 200 você deseja somar:");
        int quantidadeNumeros = LerQuantidadeNumeros();

        int soma = 0;
        int numerosLidos = 0;

        Console.WriteLine($"Digite {quantidadeNumeros} números ímpares entre 100 e 200 para calcular a soma.");

        while (numerosLidos < quantidadeNumeros)
        {
            Console.Write($"Digite o {numerosLidos + 1}º número ímpar: ");
            int numero = LerNumeroImpar();

            soma += numero;
            numerosLidos++;
        }

        Console.WriteLine($"A soma dos {quantidadeNumeros} números ímpares inseridos é: {soma}");
    }
    
    // Função para ler a quantidade de números a serem somados
    public static int LerQuantidadeNumeros()
    {
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo:");
        }
        return quantidade;
    }
    
    // Função para ler um número ímpar entre 100 e 200 do console
    public static int LerNumeroImpar()
    {
        int numero;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero >= 100 && numero <= 200 && numero % 2 != 0)
                {
                    return numero;
                }
            }
            Console.WriteLine("Por favor, digite um número ímpar entre 100 e 200:");
        }
    }
}
