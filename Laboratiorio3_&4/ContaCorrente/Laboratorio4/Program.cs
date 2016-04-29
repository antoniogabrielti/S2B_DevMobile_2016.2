using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente(1757M,"Antonio Gabriel Miranda");
            minhaConta.Depositar(500M);// M de Decimal
            minhaConta.Sacar(55M);
            Console.WriteLine("O Saldo é: " + minhaConta.Saldo);
            Console.WriteLine(Math.PI); // const é um static com inicializacao na declaracao. 
            ContaCorrente segundaConta = new ContaCorrente("Roberta Silva");
        }
    }
}
