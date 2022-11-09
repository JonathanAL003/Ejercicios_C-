using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._2._2
{
    class Circunferencia: IFigura, IEquatable<Circunferencia>
    {
        private double _dblRadio;

        public double Radio
        {
            get { return _dblRadio; }
            set
            {
                _dblRadio = value;
                if (_dblRadio <= 0)
                {
                    throw new Exception("Dato incorrecto, ingrese un dato valido(No 0 o negativo)");
                }
            }
        }

        public double CalcularPerimetro()
        {
            return (Math.Round((2 * Math.PI * Radio), 2));
        }

        public double CalcularArea()
        {
            return (Math.Round(Math.PI * Math.Pow(Radio, 2), 2));
        }

        public bool Equals(Circunferencia otraCosa)
        {
            return (this.CalcularArea() == otraCosa.CalcularArea());
        }
    }
}
