using System;
using System.Globalization;

namespace Exercicio_1_Classe_Estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, compra, resultado;

            Console.Write("Qual é a cotação do dolar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = ConversorDeMoeda.Conversor(cotacao, compra);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
