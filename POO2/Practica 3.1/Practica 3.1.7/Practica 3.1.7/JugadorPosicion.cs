using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._7
{
    class JugadorPosicion:Bateadores
    {
        public JugadorPosicion(int intErrores,int intHits, int intNumeroUniforme, string strNombre, string strPosicion): base(intHits,intNumeroUniforme, strNombre, strPosicion)
        {
            _intErrores = intErrores;
        }
        private int _intErrores;

        public int Errores
        {
            get { return _intErrores; }
            set { _intErrores = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "\nErrores: " + Errores;
        }
    }
}
