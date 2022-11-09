using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._11
{
    class Comida
    {
        public Comida(string strNombre, double dblPrecio)
        {
            _strNombre = strNombre;
            _dblPrecio = dblPrecio;
        }

        private string _strNombre;
        private double _dblPrecio;
        
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        public override string ToString()
        {
            return ("Nombre: " + Nombre + "\nPrecio: $" + Precio);
        }
    }
}
