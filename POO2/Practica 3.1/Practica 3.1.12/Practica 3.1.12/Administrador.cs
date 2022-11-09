using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._12
{
    class Administrador:Empleado
    {
        private string _strPuesto;

        public string Puesto
        {
            get { return _strPuesto; }
            set { _strPuesto = value; }
        }
        public string d;
        public void Administrar()
        {
            d = Nombre + " esta administrando";
        }
    }
}
