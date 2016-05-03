using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstadoBinario[] lista = new IEstadoBinario[2];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(lista[i].Estado);
            }
            foreach(var dispositivo in lista)
            {
                dispositivo.Ligar();
                Console.WriteLine(dispositivo.Estado);
            }
            foreach (var dispositivo in lista)
            {
                Console.WriteLine(dispositivo.Estado);
            }
        }
    }
}
