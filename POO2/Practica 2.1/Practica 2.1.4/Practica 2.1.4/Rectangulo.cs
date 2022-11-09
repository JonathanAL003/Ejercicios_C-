using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._4
{
    class Rectangulo
    {
        private double _dblLargo;
        private double _dblAncho;
        private double Area;

        public double Largo
        {
            get { return _dblLargo; }
            set { _dblLargo = value; }
        }
              
        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value; }
        }

        public double CalcularArea()
        {
            return Area = (Largo * Ancho);
        }

    }
}
