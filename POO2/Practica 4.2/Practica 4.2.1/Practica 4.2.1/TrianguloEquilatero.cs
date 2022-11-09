using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._2._1
{
    class TrianguloEquilatero: IFigura
    {
        private double _dblLado;

        public double Lado
        {
            get { return _dblLado; }
            set { _dblLado = value;
                if (_dblLado <=0)
                {
                    throw new Exception("Dato incorrecto, ingrese un dato valido(No 0 o negativo)");
                }
            }
        }

        public double CalcularPerimetro()
        {
            return (Math.Round((3 * Lado),2));
        }

        public double CalcularArea()
        {
            return (Math.Round((Math.Sqrt(3*Lado)/2),2));
        }
    }
}
