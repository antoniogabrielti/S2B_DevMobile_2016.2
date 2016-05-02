using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteHeranca
{
    public class ProdutoPerecivel : Produto 
    {
        private DateTime data;

        public ProdutoPerecivel(string d, double p, DateTime dv) : base(p,d)
        {
            data = dv;
        }
    }
}
