using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> listaStrings = new List<string>();
            listaStrings.Add("adfhsdhsgh");
            listaStrings.Add("breyretyrty");
            listaStrings.Add("cfhkkjyu");
            Console.WriteLine(listaStrings.Max());
            Console.WriteLine(listaStrings.Min());
            var r = from s in listaStrings select s.ToUpper();
            foreach(var i in r)
            {
                Console.WriteLine(i);
            }
        }
    }
}
