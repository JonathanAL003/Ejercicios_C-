using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1._2
{
    abstract class Empleado
    {
        private int _intHorasTrabajadas;
        private double _dblSueldoPorHora;

        public int HorasTrabajadas
        {
            get { return _intHorasTrabajadas; }
            set { _intHorasTrabajadas = value; }
        }

        public double SueldoPorHora
        {
            get { return _dblSueldoPorHora; }
            set { _dblSueldoPorHora = value; }
        }

        public virtual double CalcularSalario()
        {
            double salario = SueldoPorHora * HorasTrabajadas;
            return (salario);
        }
    }
}
