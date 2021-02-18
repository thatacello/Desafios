using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_04
{
    public abstract class Transporte
    {
        public abstract double calcularFrete(double valor, double peso);
    }
}
