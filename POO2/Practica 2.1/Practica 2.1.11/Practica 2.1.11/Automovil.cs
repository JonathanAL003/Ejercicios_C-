using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._11
{
    class Automovil
    {
        private double _dblCostoAutomovil;

        public double CostoAutomovil
        {
            get { return _dblCostoAutomovil; }
            set { _dblCostoAutomovil = value; }
        }

        public double CalcularGanancia()
        {
            return (Math.Round(((CostoAutomovil*12)/100),2));
        }
        public double CalcularImpuesto()
        {
            return (Math.Round(((CostoAutomovil*6)/100),2));
        }
        public double CalcularCostoFinal()
        {
            return (Math.Round((CostoAutomovil + CalcularGanancia() + CalcularImpuesto()),2));
        }
    }
}
