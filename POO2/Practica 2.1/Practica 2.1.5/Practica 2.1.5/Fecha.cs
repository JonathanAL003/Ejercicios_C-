using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._5
{
    class Fecha
    {
        private int _intDia;
        private int _intMes;
        private int _intAño;

        public int Dia
        {
            get { return _intDia; }
            set { _intDia = value; }
        }

        public int Mes
        {
            get { return _intMes; }
            set { _intMes = value; }
        }
        
        public int Año
        {
            get { return _intAño; }
            set { _intAño = value; }
        }

        public Fecha(int Dia, int Mes, int Año)
        {
            _intDia = Dia;
            _intMes = Mes;
            _intAño = Año;
        }

        public string ConsultarFecha()
        {
            return (Dia + "/" + Mes + "/" + Año);
        }

        public void ConsultarFechaLetra()
        {
            switch (Mes)
            {
                case 1:
                    MessageBox.Show(Dia + " de Enero del " +Año);
                    break;
                case 2:
                    MessageBox.Show(Dia + " de Febrero del " + Año);
                    break;
                case 3:
                    MessageBox.Show(Dia + " de Marzo del " + Año);
                    break;
                case 4:
                    MessageBox.Show(Dia + " de Abril del " + Año);
                    break;
                case 5:
                    MessageBox.Show(Dia + " de Mayo del " + Año);
                    break;
                case 6:
                    MessageBox.Show(Dia + " de Junio del " + Año);
                    break;
                case 7:
                    MessageBox.Show(Dia + " de Julio del " + Año);
                    break;
                case 8:
                    MessageBox.Show(Dia + " de Agosto del " + Año);
                    break;
                case 9:
                    MessageBox.Show(Dia + " de Septiembre del " + Año);
                    break;
                case 10:
                    MessageBox.Show(Dia + " de Octubre del " + Año);
                    break;
                case 11:
                    MessageBox.Show(Dia + " de Noviembre del " + Año);
                    break;
                case 12:
                    MessageBox.Show(Dia + " de Diciembre del " + Año);
                    break;

            }
        }

        public string VerificarFecha()
        {
            if (Dia > 31 || Dia < 1 || Mes > 12 || Mes < 1 || Año < 1)
            {
                Dia = 25;
                Mes = 10;
                Año = 2001;
                return ("Fecha invalida, se restablecera a 25/10/2001");
            }
            else
            {
                Dia = _intDia;
                Mes = _intMes;
                Año = _intAño;
                return ("Fecha Valida" );
            }
        }

    }
}
