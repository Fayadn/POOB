using System;
using System.Globalization;

namespace Conta_Banco
{
    class Conta
    {
        public string Nome { get; set; }
        public int NConta { get; private set; }
        public double Saldo { get; private set; }
        public Conta(string nome, int nconta)
        {
            Nome = nome;
            NConta = nconta;
        }

        public Conta (string nome, int nconta, double depositoInicial) : this(nome, nconta)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NConta + ", Titular:" + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
