using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoPerecivel pp = new ProdutoPerecivel("a", 1.99, new DateTime(2016, 12, 25));
            Console.WriteLine(pp.Preco);
        }
    }
}
