using System;
using System.Globalization;

namespace Exercicio_1_Classe_Estatica
{
    class ConversorDeMoeda
    {
        public static double Iof = 1.06;

        public static double Conversor(double cotacao, double compra)
        {
            return Iof * cotacao * compra;
        }
        

    }
}
