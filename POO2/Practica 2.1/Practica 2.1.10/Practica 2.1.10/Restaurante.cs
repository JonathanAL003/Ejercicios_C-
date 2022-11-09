using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._10
{
    class Restaurante
    {
        private int _intPrecioHS, _intPrecioHQ, _intPrecioHE, _intPrecioPF, _intPrecioR, _intPrecioP;

        public int PrecioHS
        {
            get { return _intPrecioHS; }
            set { _intPrecioHS = value; }
        }
        public int PrecioHQ
        {
            get { return _intPrecioHQ; }
            set { _intPrecioHQ = value; }
        }
        public int PrecioHE
        {
            get { return _intPrecioHE; }
            set { _intPrecioHE = value; }
        }
        public int PrecioPF
        {
            get { return _intPrecioPF; }
            set { _intPrecioPF = value; }
        }
        public int PrecioR
        {
            get { return _intPrecioR; }
            set { _intPrecioR = value; }
        }
        public int PrecioP
        {
            get { return _intPrecioP; }
            set { _intPrecioP = value; }
        }
        public Restaurante(int PrecioHS, int PrecioHQ, int PrecioHE, int PrecioPF, int PrecioR, int PrecioP)
        {
            _intPrecioHS = PrecioHS;
            _intPrecioHQ = PrecioHQ;
            _intPrecioHE = PrecioHE;
            _intPrecioPF = PrecioPF;
            _intPrecioR = PrecioR;
            _intPrecioP = PrecioP;
        }
        private int _intCantidadHS, _intCantidadHQ, _intCantidadHE, _intCantidadPF, _intCantidadR, _intCantidadP;

        public int CantidadHS
        {
            get { return _intCantidadHS; }
            set { _intCantidadHS = value; }
        }
        public int CantidadHQ
        {
            get { return _intCantidadHQ; }
            set { _intCantidadHQ = value; }
        }
        public int CantidadHE
        {
            get { return _intCantidadHE; }
            set { _intCantidadHE = value; }
        }
        public int CantidadPF
        {
            get { return _intCantidadPF; }
            set { _intCantidadPF = value; }
        }
        public int CantidadR
        {
            get { return _intCantidadR; }
            set { _intCantidadR = value; }
        }
        public int CantidadP
        {
            get { return _intCantidadP; }
            set { _intCantidadP = value; }
        }

        public int CalcularTotal()
        {
            return ((PrecioHS*CantidadHS)+(PrecioHQ*CantidadHQ)+(PrecioHE*CantidadHE)+(PrecioPF*CantidadPF)+(PrecioR*CantidadR)+(PrecioP*CantidadP));
        }

    }
}
