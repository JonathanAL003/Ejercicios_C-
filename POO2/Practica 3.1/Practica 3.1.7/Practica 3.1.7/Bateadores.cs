using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._7
{
    class Bateadores : Jugador
    {
        public Bateadores(int intHits, int intNumeroUniforme, string strNombre, string strPosicion):base (intNumeroUniforme, strNombre, strPosicion)
        {
            _intHits = intHits;
        }
        private int _intHits;

        public int Hits
        {
            get { return _intHits; }
            set { _intHits = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "\nHits: " + Hits;
        }
    }
}
