using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1 = new();

            Console.WriteLine("Entre com a Largura e Altura do Retangulo:");

            ret1.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + ret1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + ret1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
