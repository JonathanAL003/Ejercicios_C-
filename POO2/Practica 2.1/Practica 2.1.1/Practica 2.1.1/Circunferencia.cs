using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._1
{
    class Circunferencia
    {
        private double radio;

        public void ModificarRadio(double r)
        {
            radio = r;
        }

        public double ConsultarRadio()
        {
            return radio;
        }

        public double CalcularArea()
        {
            return (Math.PI * radio * radio);
        }
        public double CalcularPerimetro()
        {
            return ((2 * radio) * Math.PI);
        }
    }
}
