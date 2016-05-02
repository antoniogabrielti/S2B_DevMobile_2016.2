using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteHeranca
{
    public class Produto
    {
        private string descricao;
        private double preco;

        public Produto(double d, string s)
        {
            descricao = s;
            preco = d;
        }
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
            }
        }
        public override string ToString()
        {
            return "[" + descricao + " ; " + preco + "]";
        }
    }
}
