using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._11
{
    class Sopa: Comida, IPollo, ISal, ICuchara
    {
        public Sopa(bool blnPollo, bool blnSal, bool blnCuchara, string strNombre, double dblPrecio) : base(strNombre, dblPrecio)
        {
            _blnPollo = blnPollo;
            _blnSal = blnSal;
            _blnCuchara = blnCuchara;
        }

        private bool _blnPollo, _blnSal, _blnCuchara;

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
        public bool Cuchara
        {
            get { return _blnCuchara; }
            set { _blnCuchara = value; }
        }

        public string a, b, c;

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
            if (Cuchara == true)
            {
                c = "Si";
            }
            if (Cuchara == false)
            {
                c = "No";
            }
        }

        public override string ToString()
        {
            Validacion();
            return ("Sopa\n\n" + base.ToString() + "\nPollo: " + a + "\nSal: " + b + "\nCuchara: " + c);
        }
    }
}
