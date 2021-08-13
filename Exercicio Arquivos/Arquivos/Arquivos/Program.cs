using System;
using System.IO;
using System.Globalization;


namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"F:\Source\Programação Orientada a Objetos\Exercicio Arquivos\SUMMARY.CSV";

            string souceFolderPath = Path.GetDirectoryName(sourceFilePath);
            string targetFolderPath = souceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\SUMMARY1.CSV";
            Directory.CreateDirectory(targetFolderPath);

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] vet = line.Split(',');
                        String Item = vet[0];
                        double Preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        double Qtd = double.Parse(vet[2]);
                        double Total = Preco * Qtd;
                        sw.WriteLine(Item + "," + Total.ToString("f2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}


