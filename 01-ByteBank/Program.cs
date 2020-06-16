using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente ();
            contaDaGabriela.Titular = "Gabriela";

            contaDaGabriela.Agencia = 15884;

            contaDaGabriela.Numero = 12544;

            contaDaGabriela.Saldo = 1000.0;
            Console.WriteLine(contaDaGabriela.Titular);

            Console.ReadLine();

        }
    }
}
