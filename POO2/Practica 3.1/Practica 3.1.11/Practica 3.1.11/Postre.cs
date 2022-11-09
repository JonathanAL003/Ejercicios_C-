using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._11
{
    class Postre: Comida, IAzucar, ICuchara, ITenedor
    {
        public Postre(bool blnAzucar, bool blnCuchara, bool blnTenedor, string strNombre, double dblPrecio) : base(strNombre, dblPrecio)
        {
            _blnAzucar = blnAzucar;
            _blnCuchara = blnCuchara;
            _blnTenedor = blnTenedor;  
        }

        private bool _blnAzucar, _blnCuchara, _blnTenedor;

        public bool Azucar
        {
            get { return _blnAzucar; }
            set { _blnAzucar = value; }
        }        
        public bool Cuchara
        {
            get { return _blnCuchara; }
            set { _blnCuchara = value; }
        }
        public bool Tenedor
        {
            get { return _blnTenedor; }
            set { _blnTenedor = value; }
        }

        public string a, b, c;

        public void Validacion()
        {
            if (Azucar == true)
            {
                a = "Si";
            }
            if (Azucar == false)
            {
                a = "No";
            }
            if (Tenedor == true)
            {
                b = "Si";
            }
            if (Tenedor == false)
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
            return ("Postre\n\n" + base.ToString() + "\nAzucar: " + a + "\nTenedor: " + b + "\nCuchara: " + c);
        }
    }
}
