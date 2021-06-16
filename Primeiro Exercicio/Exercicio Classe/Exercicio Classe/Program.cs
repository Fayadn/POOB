using System;

namespace Exercicio_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeira, segunda;

            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            primeira.nome = Console.ReadLine();
            Console.Write("Idade:");
            primeira.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            segunda.nome = Console.ReadLine();
            Console.Write("Idade:");
            segunda.idade = int.Parse(Console.ReadLine());

            if (primeira.idade > segunda.idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}",primeira.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}",segunda.nome);
            }


        }
    }
}
