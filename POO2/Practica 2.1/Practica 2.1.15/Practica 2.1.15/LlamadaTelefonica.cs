using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._15
{
    class LlamadaTelefonica
    {
        private int _intDuracionMinutos;

        public int DuracionMinutos
        {
            get { return _intDuracionMinutos; }
            set { _intDuracionMinutos = value;
                if (_intDuracionMinutos <= 0)
                    throw new Exception("No puede ser igual a 0, negativo, o vacio");
            }
        }

        public void CalcularCosto()
        {
            if (DuracionMinutos <= 3)
            {
                MessageBox.Show("El costo de su llamada es de $5 pesos");
            }
            if (DuracionMinutos >3)
            {
                MessageBox.Show("El costo de su llamada es de $ " + (((DuracionMinutos - 3) * 3) + 5) + " pesos");
            }
        }
    }
}
