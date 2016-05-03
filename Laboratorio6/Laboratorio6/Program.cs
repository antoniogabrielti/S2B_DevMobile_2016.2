using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaPoupanca CP = new ContaPoupanca(0.5M, new DateTime(1990,05,03), "joao");
            CP.Depositar(1000M);
            Console.WriteLine(CP.DataAniversario);
            Console.WriteLine(CP.Id);
            CP.AdicionarRedimento();
            Console.WriteLine(CP.Saldo);
            Conta[] ArrayContas = new Conta[5];
            ArrayContas[0] = CP;
            Console.WriteLine("---------- Magica Array ---------");
            Console.WriteLine(ArrayContas[0].Saldo);
        }
    }
}
