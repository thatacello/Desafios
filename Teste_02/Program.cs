using System;

namespace Teste_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // limpa o console
            Console.ForegroundColor = ConsoleColor.Green; // troca a cor da letra do console
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Um Elefante Incomoda Muita Gente");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // output
            Console.WriteLine($"{n} elefantes...");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Incomoda ");
            }
            Console.WriteLine("muito mais");

        }
    }
}
