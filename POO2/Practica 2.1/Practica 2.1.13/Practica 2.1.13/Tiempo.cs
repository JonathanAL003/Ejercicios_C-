using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._13
{
    class Tiempo
    {
        private double _dblDias, _dblSegundos;

        public double Dias
        {
            get { return _dblDias; }
            set { _dblDias = value;
                if (_dblDias <= 0)
                    throw new Exception("No puede haber dias negativos, quedar igual a 0, o vacio");
            }
        }
        public double Segundos
        {
            get { return _dblSegundos; }
            set { _dblSegundos = value; }
        }

        public Tiempo(double Dias, double Segundos)
        {
            _dblDias = Dias;
            _dblSegundos = Segundos;
        }
        public double ConvertirASegundos()
        {
            return (Dias*Segundos);
        }
    }
}
