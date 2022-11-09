using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador_de_datos_aleatorios
{
    class Empleado
    {
        public Empleado(int intNumero, string strNombre, double dblSueldo)
        {
            _intNumero = intNumero;
            _strNombre = strNombre;
            _dblSueldo = dblSueldo;
        }

        private int _intNumero;
        private string _strNombre;
        private double _dblSueldo;

        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public override string ToString()
        {
            return ("Nombre + " + Nombre + "\nNumero: " + Numero + "\nSueldo: " + Sueldo);
        }

    }
}
