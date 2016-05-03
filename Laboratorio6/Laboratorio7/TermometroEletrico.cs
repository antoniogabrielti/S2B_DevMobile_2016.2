using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class TermometroEletrico : Termometro, IEstadoBinario
    {
        private bool ligado = false;
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public EstadoBinario Estado
        {
            get
            {
                if (ligado)
                {
                    return EstadoBinario.Ligado;
                }
                else
                {
                    return EstadoBinario.Desligado;
                }
                // operador ternario => ligado? EstadoBinario.Ligado : EstadoBinario.Desligado;
            }
        }
        public override double Temperatura
        {
            get
            {
                if (ligado)
                    return base.Temperatura;
                else
                    return double.NaN;
            }
        }
    }
}
