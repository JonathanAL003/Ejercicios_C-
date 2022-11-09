using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._6
{
    class Articulo
    {
        private int _intClave , _intCantidad;
        private string _strDescripcion;
        private double _dblPrecio;        

        public int Clave
        {
            get { return _intClave; }
            set { _intClave = value; }
        }

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }
       
        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        public int Cantidad
        {
            get { return _intCantidad; }
            set { _intCantidad = value; }
        }

        public double CalcularIVA()
        {
            return ((Precio*11)/100);
        }
    }
}
