using System;
using System.Globalization;

namespace Exercicio_3
{
    class Salario
    {
        public string Nome;
        public double SalarioBruto, Impostos;

        public double SalarioLiquido()
        {
            return SalarioBruto - Impostos;
        }

        public void Aumento(double porcentagem)
        {
            SalarioBruto *= (1 + (porcentagem / 100));
        }

        public override string ToString()
        {
            return Nome + " , $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
