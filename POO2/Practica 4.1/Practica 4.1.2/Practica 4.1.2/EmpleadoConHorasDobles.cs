using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1._2
{
    class EmpleadoConHorasDobles: Empleado
    {
        private int _intHorasExtras;

        public int HorasExtras
        {
            get { return _intHorasExtras; }
            set { _intHorasExtras = value; }
        }

        public override double CalcularSalario()
        {
            double salariobase = SueldoPorHora * 40;
            HorasExtras = HorasTrabajadas - 40;
            double salarioextra = ((HorasExtras * SueldoPorHora) * 2);
            double salario = salariobase + salarioextra;
            return (salario);
        }
    }
}
