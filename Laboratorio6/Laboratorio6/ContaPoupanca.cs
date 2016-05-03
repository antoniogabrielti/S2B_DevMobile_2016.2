using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public class ContaPoupanca:Conta
    {
        private decimal taxaJuros;
        private DateTime dataAniversario;

        public ContaPoupanca(decimal j,DateTime d,string t) : base(t)
        {
            taxaJuros = j;
            dataAniversario = d;
        }
        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }
        public DateTime DataAniversario
        {
            get { return dataAniversario; }
        }
        public void AdicionarRedimento()
        {
            DateTime hoje = DateTime.Now;
            if(hoje.Day==dataAniversario.Day && hoje.Month== dataAniversario.Month)
            {
                decimal redimento = this.Saldo * taxaJuros;
                this.Depositar(redimento);
            }
        }

        public override string Id
        {
            get { return this.Titular + "(CP)"; }
        }
    }
}
