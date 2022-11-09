using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._6
{
    class Goleadores:Portero
    {
        public Goleadores(int intGoles, int intNumeroUniforme, string strNombre, string strPosicion, int intMinutosJugados):base(intNumeroUniforme,strNombre,strPosicion,intMinutosJugados)
        {
            _intGoles = intGoles;
        }
        private int _intGoles;

        public int Goles
        {
            get { return _intGoles; }
            set { _intGoles = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nGoles anotados: " + Goles;
        }
    }
}
