using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._8
{
    class Persona
    {
        public Persona(string strNombre, string strDomicilio)
        {
            _strNombre = strNombre;
            _strDomicilio = strDomicilio;
        }
        private string _strNombre,_strDomicilio;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public string Domicilio
        {
            get { return _strDomicilio; }
            set { _strDomicilio = value; }
        }
        public override string ToString()
        {
            return ("Nombre: " + Nombre + "\nDomicilio" + Domicilio);
        }
    }
}
