using System.Globalization;
using System;

namespace Exercicio_1
{
    class Retangulo
    {
        public double Largura, Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Largura * 2.00 + Altura * 2.00;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2.00) + Math.Pow(Altura, 2.00)));
        }
    }
}
