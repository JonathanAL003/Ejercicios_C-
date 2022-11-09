using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_2
{
    class Producto
    {
        private int _intRam;

        public int Ram
        {
            get { return _intRam; }
            set { _intRam = value; }
        }

        private string _strSO;

        public string SO
        {
            get { return _strSO; }
            set { _strSO = "iOS"; }
        }

        private double _dblPrecioProducto;

        public double PrecioProducto
        {
            get { return _dblPrecioProducto; }
            set { _dblPrecioProducto = value; }
        }

    }
}
