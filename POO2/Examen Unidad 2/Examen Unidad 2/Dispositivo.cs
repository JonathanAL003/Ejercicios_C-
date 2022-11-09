using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_2
{
    class Dispositivo
    {
        private string _strNombreDispositivo;

        public string NombreDispositivo
        {
            get { return _strNombreDispositivo; }
            set { _strNombreDispositivo = value; }
        }

        private double _dblPrecioDispositivo;

        public double PrecioDispositivo
        {
            get { return _dblPrecioDispositivo; }
            set { _dblPrecioDispositivo = value; }
        }

    }
}
