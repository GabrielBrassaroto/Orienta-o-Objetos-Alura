



public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo = 100;


    public bool Sacar(double valor)
    {

        if (this.Saldo < valor)
        {
            return false;
        }
        else
        {
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    }

}