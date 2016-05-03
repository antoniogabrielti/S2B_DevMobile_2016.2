using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class Termometro
    {
        private double temperatura;
        public Termometro()
        {
            temperatura = 0.0;
        }
        public virtual double Temperatura
        {
            get { return temperatura; }
        }
        public  virtual void Aumentar(double t)
        {
            temperatura += t;
        }
        public virtual void Diminuir(double t)
        {
            temperatura -= t;
        }
    }
}
