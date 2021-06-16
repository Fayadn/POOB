using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] vect = new Room[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string mail = Console.ReadLine();
                Console.Write("Quarto:");
                int nroom = int.Parse(Console.ReadLine());
                vect[nroom] = new Room (name,mail);
            }

            Console.WriteLine("Quartos Ocupados:");

            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
