using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Program
    {
       static void main(String[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
        }
    }
}
