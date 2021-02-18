using System;

namespace Teste_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MaiorNumero();

            static void MaiorNumero()
            {
                Console.Clear(); // limpa o console
                Console.ForegroundColor = ConsoleColor.Blue; // troca a cor da letra do console
                Console.WriteLine("------------------");
                Console.WriteLine();
                Console.WriteLine("Bem-vind@");
                Console.WriteLine();
                Console.WriteLine("------------------");
                Console.WriteLine();

                Console.WriteLine("Digite 3 números: ");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());

                if (n1 == n2 && n1 == n3)
                {
                    Console.WriteLine("Os três números são iguais!");
                }
                else if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("O maior número é " + n1);
                }
                else if (n2 > n1 && n2 > n3)
                {
                    Console.WriteLine("O maior número é " + n2);
                }
                else
                {
                    Console.WriteLine("O maior número é " + n3);
                }

                Continuar();
            }

            static void Continuar() // pergunta se o usuário deseja continuar
            {
                Console.WriteLine();
                Console.Write("Deseja continuar (s/n)? ");
                string continuar = Console.ReadLine();

                if (continuar == "s" || continuar == "S")
                {
                    MaiorNumero();
                }
                else
                {
                    Console.WriteLine("Obrigad@!");
                    Environment.Exit(0);
                }
            }
        }
    }
}


