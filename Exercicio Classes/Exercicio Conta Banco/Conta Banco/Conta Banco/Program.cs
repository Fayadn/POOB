using System;
using System.Globalization;

namespace Conta_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta pf1;

            Console.Write("Entre com o número da conta: ");
            int nconta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoinicial = Console.ReadLine();

            if (depositoinicial.Equals("s"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                pf1 = new Conta(nome, nconta, depositoInicial);

            }
            else
            {
                pf1 = new Conta(nome,nconta);
            }

            
            Console.WriteLine();

            Console.WriteLine("Dados da conta :");
            Console.WriteLine(pf1);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pf1.Deposito(quantia);

            Console.WriteLine();

            Console.Write("Dados da Conta atualizados: ");
            Console.WriteLine(pf1);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pf1.Saque(quantia);

            Console.WriteLine();

            Console.Write("Dados da Conta atualizados: ");
            Console.WriteLine(pf1);
        }
    }
}
