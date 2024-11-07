using System;

public class Conta
{
    private double _saldo;
    public void SetSaldo(double saldo)
    {
        if (saldo >= 0)
        {
            _saldo = saldo;
        }
        else
        {
            Console.WriteLine("Saldo Inválido!");
        }
    }
}
