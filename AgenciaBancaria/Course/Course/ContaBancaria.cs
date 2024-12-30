using System.Globalization;

namespace Course
{
    class ContaBancaria
    {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public ContaBancaria(int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}