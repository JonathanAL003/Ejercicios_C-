using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._8
{
    class CambioDivisas
    {
        private double _dblPesos;
        private double _dblTipoCambio;

        public double Pesos
        {
            get { return _dblPesos; }
            set { _dblPesos = value; }
        }
        
        public double TipoCambio
        {
            get { return _dblTipoCambio; }
            set { _dblTipoCambio = value; }
        }

        public CambioDivisas(double TipoCambio)
        {
            _dblTipoCambio = TipoCambio;
        }

        public double ConvertirADolares()
        {
            return Math.Round((Pesos / _dblTipoCambio),2);
        }


    }
}
