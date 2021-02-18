using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_03
{
    public class Subtracao : EfetuarOperacao
    {
        public override double efetuarOperacao(double x, double y)
        {
            return x - y;
        }
    }
}
