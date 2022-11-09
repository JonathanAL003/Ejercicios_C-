using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    abstract class Empleados
    {
        public Empleados(string strNombre, int intEdad, double dblSalario)
        {
            _strNombre = strNombre;
            _intEdad = intEdad;
            _dblSalario = dblSalario;
        }

        public double Extra = 300.00;

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private int _intEdad;

        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }

        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        private DateTime _dtmFechaActual;

        public DateTime FechaActual
        {
            get { return _dtmFechaActual; }
            set { _dtmFechaActual = value; }
        }

        private double _dblSalario;

        public double Salario
        {
            get { return _dblSalario; }
            set { _dblSalario = value; }
        }

        public override string ToString()
        {
            return ("Empleado");
        }

        public abstract void PagoExtra();

    }
}
