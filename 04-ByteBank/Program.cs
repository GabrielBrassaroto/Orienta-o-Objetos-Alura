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
            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.Saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.Saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";

            bool resultadoTranferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo conta do Bruno " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo conta da Gabriela " + contaDaGabriela.Saldo);
            Console.WriteLine("Resultado da transferencia " + resultadoTranferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("Saldo conta do Bruno " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo conta da Gabriela " + contaDaGabriela.Saldo);

            Console.ReadLine();
        }
    }
}
