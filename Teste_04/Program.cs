using System;

namespace Teste_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o peso da carga? ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor da carga? ");
            double valor = double.Parse(Console.ReadLine());

            Caminhao c = new Caminhao(valor, peso);
            Vagao v = new Vagao(valor, peso);

            double calculoCaminhao = c.calcularFrete(valor, peso);
            double calculoVagao = v.calcularFrete(valor, peso);

            if (peso < 15000)
            {
                Console.WriteLine();
                Console.WriteLine($"O frete do caminhão será: ${calculoCaminhao}");
                Console.WriteLine($"O frete do vagão será: ${calculoVagao + 5000}");
            }
            else if (peso > 40000)
            {
                Console.WriteLine();
                Console.WriteLine($"O frete do caminhão será: ${calculoCaminhao * 0.75}");
                Console.WriteLine($"O frete do vagão será: ${calculoVagao}");
            }
        }
    }
}
