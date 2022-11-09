using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._1._12
{
    class Estudiante:Persona
    {
        private int _intGrado;
        private char _chrGrupo;

        public int Grado
        {
            get { return _intGrado; }
            set { _intGrado = value; }
        }

        public char Grupo
        {
            get { return _chrGrupo; }
            set { _chrGrupo = value; }
        }
        public string c;
        public void Estudiar()
        {
            c = Nombre + " esta estudaindo";
        }
    }
}
