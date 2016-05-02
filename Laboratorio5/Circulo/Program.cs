using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Program
    {
       static void Main(String[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            Console.WriteLine("----------------------------");
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
            Console.WriteLine(circ4.CentroX);
            Circulo[] ArraysDeCirculos = new Circulo[4];
            ArraysDeCirculos[0] = circ1;
            ArraysDeCirculos[1] = circ2;
            ArraysDeCirculos[2] = circ3;
            ArraysDeCirculos[3] = circ4;
            Console.WriteLine("----- ArrayNa ------");
            foreach(Circulo C in ArraysDeCirculos)
            {
                Console.WriteLine(C.ToString());
            }
        }
    }
}
