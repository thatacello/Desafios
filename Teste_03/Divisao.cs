using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_03
{

    public class Divisao : EfetuarOperacao
    {
        public override double efetuarOperacao(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Não existe divisão por 0!");

            }
            return x / y;
        }
    }

}
