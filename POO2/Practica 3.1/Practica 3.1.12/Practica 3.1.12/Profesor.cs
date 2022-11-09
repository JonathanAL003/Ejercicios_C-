using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._12
{
    class Profesor:Empleado
    {
        private string _strCarrera;

        public string Carrera
        {
            get { return _strCarrera; }
            set { _strCarrera = value; }
        }
        public string e;
        public void Enseña()
        {
            e = Nombre + " enseña";
        }
    }
}
