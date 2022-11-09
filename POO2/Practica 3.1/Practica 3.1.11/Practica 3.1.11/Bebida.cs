using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._11
{
    class Bebida: Comida, IAzucar
    {
        public Bebida(bool blnAzucar, bool blnPopote, bool blnVaso, string strNombre, double dblPrecio) : base(strNombre, dblPrecio)
        {
            _blnAzucar = blnAzucar;
            _blnPopote = blnPopote;
            _blnVaso = blnVaso;
        }

        private bool _blnAzucar,_blnPopote,_blnVaso;
        
        public bool Azucar
        {
            get { return _blnAzucar; }
            set { _blnAzucar = value; }
        }
        public bool Popote
        {
            get { return _blnPopote; }
            set { _blnPopote = value; }
        }

        public string a, b;

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
            if (Popote == true)
            {
                b = "Si";
            }
            if (Popote == false)
            {
                b = "No";
            }
        }

        public override string ToString()
        {
            Validacion();
            return ("Bebidas\n\n" + base.ToString() + "\nAzucar: " + a + "\nPopote: " + b + "\nVaso: Sí");
        }
    }
}
