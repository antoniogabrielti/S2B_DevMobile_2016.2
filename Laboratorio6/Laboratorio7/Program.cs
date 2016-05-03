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
            TermometroEletrico te = lista[0] as TermometroEletrico; // operador de conversao 
            Console.WriteLine(te?.Temperatura);// ? <= este operador testa se meu objeto e NULL
            Console.WriteLine(lista[0] is Lampada); // testa se é daquele tipo(objeto)
            Console.WriteLine(lista[1] is Lampada);
            Console.WriteLine(lista[1] is Termometro);
            Console.WriteLine(lista[1].GetType()); // <= GetType informa o tipo daquele objeto

            string s1 = "abc";
            string s2 = "aBc";

            Console.WriteLine(s1.Equals(s2, StringComparison.OrdinalIgnoreCase));

            foreach(char c in s1)
            {
                Console.WriteLine(c);
            }
        }
    }
}
