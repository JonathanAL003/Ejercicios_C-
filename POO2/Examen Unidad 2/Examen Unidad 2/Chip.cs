using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_2
{
    class Chip
    {
        private string _strNombreChip;

        public string NombreChip
        {
            get { return _strNombreChip; }
            set { _strNombreChip = value; }
        }

        private double _dblCapacidad;

        public double Capacidad
        {
            get { return _dblCapacidad; }
            set { _dblCapacidad = value; }
        }

    }

}
