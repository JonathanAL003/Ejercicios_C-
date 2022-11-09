using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._2
{
    class Circunferencia
    {
        private double _dblRadio;

        public double Radio
        {
            get { return _dblRadio; }
            set { _dblRadio = value; }
        }

        public double CalcularArea()
        {
            return (Math.PI * Radio * Radio);
        }
        public double CalcularPerimetro()
        {
            return ((2 * Radio) * Math.PI);
        }
    }
}
