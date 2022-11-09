using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._2._1
{
    class Rectangulo: IFigura
    {
        private double _dblLargo, _dblAncho;

        public double Largo
        {
            get { return _dblLargo; }
            set { _dblLargo = value;
                if (_dblLargo <=0)
                {
                    throw new Exception("Dato incorrecto, ingrese un dato valido(No 0 o negativo)");
                }
            }
        }
        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value;
                if (_dblAncho <=0)
                {
                    throw new Exception("Dato incorrecto, ingrese un dato valido(No 0 o negativo)");
                }
            }
        }

        public double CalcularPerimetro()
        {
            return (Math.Round(2*(Ancho + Largo),2));
        }

        public double CalcularArea()
        {
            return (Math.Round((Ancho * Largo),2));
        }
    }
}
