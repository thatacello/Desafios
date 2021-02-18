using System;

namespace Teste_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma = new Soma();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            Console.Clear(); // limpa o console
            Console.ForegroundColor = ConsoleColor.Yellow; // troca a cor da letra do console
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Calculadora");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            Console.WriteLine("Digite dois números");
            Console.Write("Primeiro número: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(); // espaço

            Console.WriteLine("A soma é: " + soma.efetuarOperacao(x, y));
            Console.WriteLine("A subtração é: " + subtracao.efetuarOperacao(x, y));
            Console.WriteLine("A multiplicação é: " + multiplicacao.efetuarOperacao(x, y));
            Console.WriteLine("A divisão é: " + divisao.efetuarOperacao(x, y).ToString("F2"));
        }
    }
}
