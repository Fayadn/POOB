using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario Func = new();
            double porcentagem;

            Console.Write("Nome: ");
            Func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            Func.Impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + Func);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Func.Aumento(porcentagem);

            Console.WriteLine("Dados Atualizados: " + Func);


        }
    }
}
