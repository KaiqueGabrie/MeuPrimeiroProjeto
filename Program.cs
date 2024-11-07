using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.WriteLine("Informe o valor do saldo: ");
            double saldo = double.Parse(Console.ReadLine());
            c.SetSaldo(saldo);
        }
    }
}
