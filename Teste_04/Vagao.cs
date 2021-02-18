using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_04
{
    public class Vagao : Transporte
    {
        public double Valor { get; set; }
        public double Peso { get; set; }

        public Vagao(double valor, double peso)
        {
            Valor = valor;
            Peso = peso;
        }

        public Vagao()
        {
        }

        public override double calcularFrete (double valor, double peso)
        {
            double frete = (Valor * 0.1) + (Peso * 0.2);

            return frete;
        }
    }
}
