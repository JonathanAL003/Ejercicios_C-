using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._12
{
    class Persona
    {
        public string a;
        private string _strNombre,_strDomicilio,_strHorario;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public string Domicilio
        {
            get { return _strDomicilio; }
            set { _strDomicilio = value; }
        }
        public string Horario
        {
            get { return _strHorario; }
            set { _strHorario = value; }
        }

        public void Asistir()
        {
            a = Nombre + " asiste a la escuela";
        }
    }
}
