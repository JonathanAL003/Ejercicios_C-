using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._7
{
    class Pitcher:JugadorPosicion
    {
        public Pitcher(int intPonches,int intErrores, int intNumeroUniforme, string strNombre, string strPosicion) :base(intErrores,intPonches, intNumeroUniforme, strNombre, strPosicion)
        {
            _intPonches = intPonches;
        }
        private int _intPonches;

        public int Ponches
        {
            get { return _intPonches; }
            set { _intPonches = value; }
        }
        public override string ToString()
        {
            return ("Nombre: " + Nombre + "\nNumero de uniforme: " + NumeroUniforme + "\nPosicion: " + Posicion + "\nErrores: " + Errores + "\nPonches: " + Ponches);
        }
    }
}
