using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_04
{
    public class Caminhao : Transporte
    {
        public double Valor { get; set; }
        public double Peso { get; set; }

        public Caminhao(double valor, double peso)
        {
            Valor = valor;
            Peso = peso;
        }

        public Caminhao()
        {
        }

        public override double calcularFrete(double valor, double peso)
        {
            double frete = (Peso * 0.12) + (Valor * 0.3);

            if (Valor > 40000)
            {
                frete = frete * 0.75;
            }

            return frete;
        }
    }
}
