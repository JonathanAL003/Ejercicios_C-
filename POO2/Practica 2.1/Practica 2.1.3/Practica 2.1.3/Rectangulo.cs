using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._3
{
    class Rectangulo
    {
        private double largo, ancho,area;

        public double CalcularArea()
        {
            return area = (largo * ancho);
        }

        public void ModificarLargo(double l)
        {
            largo = l;
        }

        public void ModificarAncho(double a)
        {
            ancho = a;
        }

        public double ConsultarLargo()
        {
            return largo;
        }

        public double ConsultarAncho()
        {
            return ancho;
        }
    }
}
