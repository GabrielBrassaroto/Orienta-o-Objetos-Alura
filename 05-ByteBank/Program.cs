using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cliente gabriela = new Cliente();

          //  gabriela.nome = "Gabriela";
           // gabriela.profissao = "Desenvolvedora C#";
           // gabriela.cpf = "434.562.878-28";

            ContaCorrente conta = new ContaCorrente();
            ///conta.titular = gabriela;// referencia o campo titular a conta da gabriela que ja foi criada
            //outro jeito de criar o metodos e popular pela conta
           // conta.titular = new Cliente();
           // conta.titular.nome = "Gabriela Costa";
           // conta.titular.cpf = "434.562.878-28";
           // conta.titular.profissao = "Desenvolvedora C#";

            conta.Saldo = 500;
            conta.Agencia = 563;
            conta.Numero = 5634527;
            if(conta.titular == null)
            {
                Console.WriteLine("Ops o titular esta vazio");
            }

           // Console.WriteLine(gabriela.nome);
             // Console.WriteLine(conta.titular.nome);// acesando o nome pelo titular
           /// Console.WriteLine(conta.titular.cpf);// acesando o nome pelo titular
            /// Console.WriteLine(conta.titular.profissao);// acesando o nome pelo titular

            Console.ReadLine();

        }
    }
}
