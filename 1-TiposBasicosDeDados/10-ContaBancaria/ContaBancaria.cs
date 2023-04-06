using System.Globalization;
{
    class ContaBancaria
{
    public int Numero { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    //Construtor 2 argumentos
    public ContaBancaria(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }

    //Construtor 3 argumentos
    public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
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
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
}
}

/*public double _saldo
{
    get { return _saldo; }
    set { (if value > 0)
            
    } 
}*/

