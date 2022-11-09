using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    class Comercial:Empleados
    {
        public Comercial(double dblComision, string strNombre, int intEdad, double dblSalario) : base(strNombre, intEdad, dblSalario)
        {
            _dblComision = dblComision;
        }

        private double _dblComision;

        public double Comision
        {
            get { return _dblComision; }
            set { _dblComision = value; }
        }

        public override void PagoExtra()
        {
            if (Edad > 30 && Comision > 200)
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
            return("Comercial - " + Nombre);
        }
    }
}
