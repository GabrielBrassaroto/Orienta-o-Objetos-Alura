using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.Titular = "Burno";

            Console.WriteLine(contaDoBruno.Saldo);
            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.Saldo);
            Console.WriteLine(resultadoSaque);


            Console.ReadLine();
        }
    }
}
