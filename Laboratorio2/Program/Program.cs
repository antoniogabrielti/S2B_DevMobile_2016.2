using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            b = byte.MaxValue;
            Console.WriteLine("Valor maximo de byte: " + b);

            string strprimeira = "Alo";
            string strsegunda = "Mundo";
            string terceira = strprimeira + strsegunda;
            Console.WriteLine(terceira);

            int cchTamanho = terceira.Length;
            string strQuarta = "Tamanho = " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);
            Console.WriteLine(terceira.Substring(0,5));

            DateTime dt = new DateTime(2015,04,23);
            String strQuinta = dt.ToString();
            Console.WriteLine(strQuinta);
            int caseSwitch = 1;
            switch (caseSwitch)
            {
                // The following switch section causes an error.
                case 1:
                case 2:
                    Console.WriteLine("Case 1 or Case 2");
                    break;

            }

            int[] arrint;
            arrint = new int[3];
            Console.WriteLine(arrint.Length);
            arrint[0] = 1;
            Console.WriteLine(arrint[0]);
            Console.WriteLine("---------Iteracao Vetor-----------");
            for(int i=0;i<arrint.Length;i++)
            {
                Console.WriteLine(arrint[i]);
            }
            Console.WriteLine("---------Iteracao Vetor Usando Foreach-----------");
            foreach(int a in arrint)
            {
                Console.WriteLine(a);
            }
            int[,] arr2d;
            arr2d = new int[2, 3];
            arr2d[1, 2] = 1;
            Console.WriteLine(arr2d.Length);
            Console.WriteLine(arr2d.Rank);
            Console.WriteLine(arr2d.GetLength(1));
            Console.WriteLine("----------- Iteracao de multiplas dimensoes no Array ---------");
            foreach( int v in arr2d)
            {
                Console.WriteLine(v);
            }

            // array serrilhado
            int[][] arrd;
            arrd = new int[2][];
            arrd[0] = new int[3];
            arrd[1] = new int[5];
            arrd[1][3] = 1;
            Console.WriteLine("-----------Array serrilhado(array com outro array)---------");
            foreach(int[] i in arrd)
            {
                foreach (int valor in i)
                {
                    Console.WriteLine(valor);
                }
            }


        }
    }
}
