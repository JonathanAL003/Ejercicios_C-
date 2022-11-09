using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._11
{
    class Ensalada: Comida, IPollo, ISal, ITenedor, ICuchillo
    {
        public Ensalada(bool blnPollo, bool blnSal, bool blnTenedor, bool blnCuchillo, string strNombre, double dblPrecio) : base(strNombre, dblPrecio)
        {
            _blnPollo = blnPollo;
            _blnSal = blnSal;
            _blnTenedor = blnTenedor;
            _blnCuchillo = blnCuchillo;
        }

        private bool _blnPollo, _blnSal, _blnTenedor, _blnCuchillo;

        public bool Pollo
        {
            get { return _blnPollo; }
            set { _blnPollo = value; }
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

        public string a, b, c, d;

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
        }
            

        public override string ToString()
        {
            Validacion();
            return ("Ensalada\n\n" + base.ToString() + "\nPollo: " + a + "\nSal: " + b + "\nTenedor: " + c + "\nCuchillo: " + d);
        }
    }
}
