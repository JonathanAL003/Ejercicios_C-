using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    class Repartidor: Empleados
    {
        public Repartidor(string strZona, string strNombre, int intEdad, double dblSalario) : base(strNombre, intEdad, dblSalario)
        {
            _strZona = strZona;
        }

        private string _strZona;

        public string Zona
        {
            get { return _strZona; }
            set { _strZona = value; }
        }

        public override void PagoExtra()
        {
            if (Edad < 25 && Zona == "Zona 3")
            {
                Salario = Salario + Extra;
            }
            else
            {
                Salario = Salario;
            }
        }

        public override string ToString()
        {
            return ("Repartidor - " + Nombre);
        }
    }
}
