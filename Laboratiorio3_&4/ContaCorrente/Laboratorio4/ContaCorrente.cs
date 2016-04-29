using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    public class ContaCorrente
    {
        private decimal saldo;
        private string nomeTitular;
        private readonly DateTime dataCriacao;
        /// <summary>
        /// Construtor da classe ContaCorrente
        /// </summary>
        /// <param name="SaldoInicial">Saldo inicial da conta</param>
        public ContaCorrente(decimal SaldoInicial, string nome)
        {
            saldo = SaldoInicial;
            nomeTitular = nome;
            dataCriacao = DateTime.Now;
        }

        public ContaCorrente(string nomecliente) : this(0M,nomecliente) /* sobrecarga construtor chamando o outro
            construtor de cima*/
        {
        }
        public void Depositar(decimal val)
        {
            saldo = saldo + val;
        }
        public void Sacar (decimal val)
        {
            Saldo = val;
        }
        
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            private set
            {
                saldo = value; // VALUE valor da propriedade que sera guardado
            }
        }
    }
}
