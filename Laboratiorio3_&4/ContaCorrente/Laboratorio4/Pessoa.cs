using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Pessoa
    {
        private string[] nomes = new string[3];
        private int idade;

        public string this[int i]
        {
            get { return nomes[i]; }
            set { nomes[i] = value; }
        }

        public int IdadeAtual
        {
            get;
            set;
            /*
            get -> public string Name => First +" " + Last;
            get { return idade; }
            set { idade = value; }
            get e set com ; é o get e set auto-gerado
            */
        }
    }
}
