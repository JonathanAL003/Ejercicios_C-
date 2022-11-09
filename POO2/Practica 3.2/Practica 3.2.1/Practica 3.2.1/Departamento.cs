using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._2._1
{
    class Departamento
    {
        private int _intNumero;
        private string _strNombre, _strJefe;

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
        public string Jefe
        {
            get { return _strJefe; }
            set { _strJefe = value; }
        }
    }
}
