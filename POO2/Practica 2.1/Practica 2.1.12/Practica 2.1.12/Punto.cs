using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._12
{
    class Punto
    {
        private int _intCoordenadaX, _intCoordenadaY;

        public int CoordenadaX
        {
            get { return _intCoordenadaX; }
            set { _intCoordenadaX = value; }
        }

        public int CoordenadaY
        {
            get { return _intCoordenadaY; }
            set { _intCoordenadaY = value; }
        }        
    }
}
