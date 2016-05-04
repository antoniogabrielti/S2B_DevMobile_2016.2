using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_LinqtoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), Casada=true},
                new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,10,23), Casada=false},
                new Pessoa{Nome="Ana Maria", DataNascimento=new DateTime(1980,3,14), Casada=false},
                new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), Casada=true},
                new Pessoa{Nome="Pedro", DataNascimento=new DateTime(1970,5,27), Casada=false},
                new Pessoa{Nome="Huginho", DataNascimento=new DateTime(1970,5,27), Casada=true},
                new Pessoa{Nome="Zezinho", DataNascimento=new DateTime(1980,3,17), Casada=false},
                new Pessoa{Nome="Luizinho", DataNascimento=new DateTime(1990,7,7), Casada=false}

            };

            // Como construir uma lista com todas as pessoas casadas ?
            Console.WriteLine("*** Consulta tradicional ***");
            Console.WriteLine(">>> Pessoas casadas");
            var casadas = new List<Pessoa>();
            foreach (var p in pessoas)
            {
                if (p.Casada)
                    casadas.Add(p);
            }
            foreach (var p in casadas)
                Console.WriteLine(p);
           

            Console.WriteLine("\n*** Consultas com LINQ ***");
            Console.WriteLine(">>> Pessoas casadas");
            var r0 = from p in pessoas
                     where p.Casada
                     select p;
            foreach (var p in r0)
                Console.WriteLine(p);
          

            Console.WriteLine("\n>>> Pessoas casadas nascidas em ou após 1980");
            var r1 = from p in pessoas
                     where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
                     select p;
            foreach (var p in r1)
                Console.WriteLine(p);
            
            Console.WriteLine("\n>>> Nomes das pessoas casadas");
            var r2 = from p in pessoas
                     where p.Casada
                     select p.Nome;
            foreach (var p in r2)
                Console.WriteLine(p);
            
            Console.WriteLine("\n>>> Nome e data de nascimento das pessoas casadas");

            int cont = 0;
            var r3 = from p in pessoas
                     where p.Casada
                     select new { Id = ++cont, p.Nome, p.DataNascimento };// construtor anonimo

            Console.WriteLine("contador...: " + cont);

            foreach (var p in r3)
                Console.WriteLine(p.Id + ": " + p.Nome + " " + p.DataNascimento);
            Console.WriteLine();

            Console.WriteLine("contador...: " + cont);
            Console.ReadKey();


            Console.WriteLine(">>> Pessoas ordenadas pelo nome");
            var r4 = from p in pessoas
                     orderby p.Nome
                     select p;
            foreach (var p in r4)
                Console.WriteLine(p.Nome);
            Console.WriteLine();

            Console.WriteLine(">>> Pessoas ordenadas pelo nome - extension methods");
            //IEnumerable<string> r4e =  pessoas.Where( p => p.Casada ).OrderBy( p => p.Nome ).Select( p => p.Nome.ToUpper() );
            IEnumerable<string> r4e = pessoas.Where(p => p.Casada)
                                             .OrderBy(p => p.Nome)
                                             .Select(p => p.Nome.ToUpper());

            foreach (var nome in r4e)
                Console.WriteLine(nome);
            Console.WriteLine();
            Console.ReadKey();




            Console.WriteLine(">>> Pessoas ordenadas inversamente pelo nome");
            var r5 = from p in pessoas
                     orderby p.Nome descending
                     select p;
            foreach (var p in r5)
                Console.WriteLine(p.Nome);
            Console.WriteLine();

            Console.WriteLine(">>> Pessoas ordenadas pela data de nascimento e nome");
            var r6 = from p in pessoas
                     orderby p.DataNascimento, p.Nome
                     select p;
            foreach (var p in r6)
                Console.WriteLine(p.DataNascimento + " " + p.Nome);
            Console.WriteLine();

            Console.WriteLine(">>> Pessoas agrupadas pelo estado civil");
            var r7 = from p in pessoas
                     group p by p.Casada;
            foreach (var g in r7)
            {

                Console.WriteLine("Categoria: " + (g.Key ? "CASADAS" : "SOLTEIRAS") + " quantidade: " + g.Count());
                foreach (var p in g)
                    Console.WriteLine("  " + p.Nome);
            }
            Console.WriteLine();

            Console.WriteLine(">>> Projeção de pessoas agrupadas pelo estado civil");
            var r8 = from p in pessoas
                     group p by p.Casada
                         into grupoPessoas
                         select new { Categoria = grupoPessoas.Key, Pessoas = grupoPessoas, NroPessoas = grupoPessoas.Count() };

            foreach (var g in r8)
            {
                Console.WriteLine("Categoria: " + g.Categoria + " Quantidade: " + g.NroPessoas);

                foreach (var p in g.Pessoas)
                    Console.WriteLine("  " + p.Nome);
            }
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("\n>>> Total de pessoas casadas");
            var r9 = (from p in pessoas
                      where p.Casada
                      select p).Count();
            Console.WriteLine(r9);
            Console.WriteLine();



            Console.WriteLine("\n>>> Pessoa mais velha");
            var r10 = (from p in pessoas
                       orderby p.DataNascimento ascending
                       select p).First();
            Console.WriteLine(r10);
            Console.WriteLine();

            Console.WriteLine("\n>>> Pessoa solteira mais nova");
            var r11 = (from p in pessoas
                       orderby p.DataNascimento descending
                       where !p.Casada
                       select p).First();
            Console.WriteLine(r11);

            Console.WriteLine("\n>>> Pessoa + idosa");
            var r12 = (from p in pessoas
                       let maiorIdade = pessoas.Min(q => q.DataNascimento)
                       where p.DataNascimento == maiorIdade
                       select p).First();
            Console.WriteLine(r12);

            Console.WriteLine("\n>>> Pessoa + idosa v2");
            var r13 = (from p in pessoas
                       let maiorIdade = pessoas.Min(q => q.DataNascimento)
                       where p.DataNascimento == maiorIdade
                       select p);
            foreach (var p in r13)
                Console.WriteLine(p);

            Console.WriteLine();


            Console.WriteLine("\n>>> Data de nascimento da + nova");
            var r14 = (from p in pessoas
                       where !p.Casada
                       select p).Max(p => p.DataNascimento);

            Console.WriteLine(r14);

            Console.WriteLine("\n>>> Solteira + nova");
            var r15 = (from p in pessoas
                       let maiorIdade = pessoas.Where(q => !q.Casada).Max(q => q.DataNascimento)
                       where p.DataNascimento == maiorIdade
                       select p).First();
            Console.WriteLine(r15);



            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
