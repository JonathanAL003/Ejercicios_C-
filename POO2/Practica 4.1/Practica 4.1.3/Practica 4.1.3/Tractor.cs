using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1._3
{
    class Tractor: Vehiculo
    {
        private double _dblPrecioPorDia;

        public override double Precio
        {
            get { return _dblPrecioPorDia; }
            set { _dblPrecioPorDia = value;
                if (_dblPrecioPorDia <=0)
                {
                    throw new Exception("Precio invalido(No puede ser 0 o negativo), intentelo de nuevo");
                }                
            }
        }

        DateTime _dtmFechaRenta;
        DateTime _dtmFechaDevolucion;

        public DateTime FechaRenta
        {
            get { return _dtmFechaRenta; }
            set { _dtmFechaRenta = value; }
        }

        public DateTime FechaDevolucion
        {
            get { return _dtmFechaDevolucion; }
            set { _dtmFechaDevolucion = value;
                if (_dtmFechaDevolucion < _dtmFechaRenta)
                {
                    throw new Exception("Fecha invalida, no se puede devolver antes de rentarlo\n\nOh acaso eres un viajante en el tiempo eh? .-.");
                }
            }
        }

        public override string ConsultarDisponibilidad()
        {
            return base.ConsultarDisponibilidad();
        }
    }
}
