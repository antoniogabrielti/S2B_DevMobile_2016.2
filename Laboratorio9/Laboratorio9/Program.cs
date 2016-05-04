using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> listaStrings = new List<String>();
            listaStrings.Add("Um");
            listaStrings.Add("Hello");
            listaStrings.Add("World");
            Console.WriteLine(listaStrings[0]);
            Console.WriteLine(listaStrings[1]);
            Console.WriteLine(listaStrings[2]);
            listaStrings.Insert(1, "X"); // a inserção no sobrescreve o elemento naquela posição

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";
            Console.WriteLine("O código 55 é: {0}", paises[55]);
            foreach(KeyValuePair<int,string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }
        }
    }
}
