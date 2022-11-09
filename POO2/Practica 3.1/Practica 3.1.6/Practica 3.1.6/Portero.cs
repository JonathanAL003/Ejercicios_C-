using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._6
{
    class Portero
    {
        public Portero(int intNumeroUniforme, string strNombre, string strPosicion, int intMinutosJugados)
        {
            _intNumeroUniforme = intNumeroUniforme;
            _strNombre = strNombre;
            _strPosicion = strPosicion;
            _intMinutosJugados = intMinutosJugados;
        }

        private int _intNumeroUniforme,_intMinutosJugados;
        private string _strNombre,_strPosicion;

        public int NumeroUniforme
        {
            get { return _intNumeroUniforme; }
            set { _intNumeroUniforme = value; }
        }
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public string Posicion
        {
            get { return _strPosicion; }
            set { _strPosicion = value; }
        }
        public int MinutosJugados
        {
            get { return _intMinutosJugados; }
            set { _intMinutosJugados = value; }
        }
        public override string ToString()
        {
            return ("Nombre: " + Nombre + "\nNumero de uniforme: " + NumeroUniforme + "\nPosicion: " + Posicion + "\nMinutos Jugados: " + MinutosJugados);
        }
    }
}
