using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._12
{
    class Empleado:Persona
    {
        private string _strJefe;

        public string Jefe
        {
            get { return _strJefe; }
            set { _strJefe = value; }
        }
        public string b;
        public void Cobrar()
        {          
            b = Nombre + " cobra";
        }
    }
}
