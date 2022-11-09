using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._9
{
    class Cliente:Persona
    {
        public Cliente(double dblLimiteDeCredito, string strNombre, string strDomicilio) : base(strNombre, strDomicilio)
        {
            _dblLimiteDeCredito = dblLimiteDeCredito;
        }
        private double _dblLimiteDeCredito;

        public double LimiteDeCredito
        {
            get { return _dblLimiteDeCredito; }
            set { _dblLimiteDeCredito = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "\nLimite de credito: $" + LimiteDeCredito;
        }
    }
}
