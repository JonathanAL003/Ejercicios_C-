using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._14
{
    class Numero
    {
        private int _intNumero;

        public int NumeroL
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }

        public void DescubrirPrimo()
        {
            int a = 0;
            for (int i = 1; i < (NumeroL + 1); i++)
            {
                if (NumeroL % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                MessageBox.Show(NumeroL + " ,NO es un numero primo");
            }
            else
            {
                MessageBox.Show(NumeroL + " ,SI es un numero primo");
            }
        }
        
    }
}
