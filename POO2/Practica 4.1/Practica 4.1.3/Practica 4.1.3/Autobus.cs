using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1._3
{
    class Autobus: Vehiculo
    {
        private double _dblPrecioPorKilometro;

        public override double Precio
        {
            get { return _dblPrecioPorKilometro; }
            set { _dblPrecioPorKilometro = value;
                if (_dblPrecioPorKilometro <=0)
                {
                    throw new Exception("Precio invalido(No puede ser 0 o negativo), intentelo de nuevo");
                }
            }
        }

        private double _dblKilometrosRenta, _dblKilometrosDevuelve;

        public double KilometrosRenta
        {
            get { return _dblKilometrosRenta; }
            set { _dblKilometrosRenta = value; }
        }

        public double KilometrosDevuelve
        {
            get { return _dblKilometrosDevuelve; }
            set { _dblKilometrosDevuelve = value;
                if (_dblKilometrosDevuelve < _dblKilometrosRenta)
                {
                    throw new Exception("No puede devolverse con menos kilometros con los que se retiro\n\nQue le has hecho a nuestro coche eh! ¬_¬");
                }
             }
        }

        public override string ConsultarDisponibilidad()
        {
            return base.ConsultarDisponibilidad();
        }
    }
}
