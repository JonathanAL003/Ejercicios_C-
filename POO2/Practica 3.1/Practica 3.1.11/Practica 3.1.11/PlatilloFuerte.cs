using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._11
{
    class PlatilloFuerte: Comida, IPollo, ISal, ITenedor, ICuchillo
    {
        public PlatilloFuerte(bool blnPollo, bool blnSal, bool blnTenedor, bool blnCuchillo, bool blnCarne,string strNombre, double dblPrecio) : base(strNombre, dblPrecio)
        {
            _blnPollo = blnPollo;
            _blnSal = blnSal;
            _blnTenedor = blnTenedor;
            _blnCuchillo = blnCuchillo;
            _blnCarne = blnCarne;
        }

        private bool _blnPollo,_blnSal,_blnTenedor,_blnCuchillo,_blnCarne;

        public bool Pollo
        {
            get { return _blnPollo; }
            set { _blnPollo = value;}
        }
        public bool Sal
        {
            get { return _blnSal; }
            set { _blnSal = value; }
        }
        public bool Tenedor
        {
            get { return _blnTenedor; }
            set { _blnTenedor = value; }
        }
        public bool Cuchillo
        {
            get { return _blnCuchillo; }
            set { _blnCuchillo = value; }
        }
        public bool Carne
        {
            get { return _blnCarne; }
            set { _blnCarne = value; }
        }

        public string a, b, c, d, e;

        public void Validacion()
        {
            if (Pollo == true)
            {
                a = "Si";
            }
            if (Pollo == false)
            {
                a = "No";
            }
            if (Sal == true)
            {
                b = "Si";
            }
            if (Sal == false)
            {
                b = "No";
            }
            if (Tenedor == true)
            {
                c = "Si";
            }
            if (Tenedor == false)
            {
                c = "No";
            }
            if (Cuchillo == true)
            {
                d = "Si";
            }
            if (Cuchillo == false)
            {
                d = "No";
            }
            if (Carne == true)
            {
                e = "Si";
            }
            if (Carne == false)
            {
                e = "No";
            }
        }

        public override string ToString()
        {
            Validacion();
            return ("Platillo fuerte\n\n" + base.ToString() + "\nPollo: " + a + "\nCarne: " + e + "\nSal: " + b + "\nTenedor: " + c + "\nCuchillo: " + d);
        }
    }
}
