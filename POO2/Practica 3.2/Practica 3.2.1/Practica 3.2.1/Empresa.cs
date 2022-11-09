using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._2._1
{
    class Empresa
    {
        private string _strRFC,_strRazonSocial,_strGerente;

        public string RFC
        {
            get { return _strRFC; }
            set { _strRFC = value; }
        }
        public string RazonSocial
        {
            get { return _strRazonSocial; }
            set { _strRazonSocial = value; }
        }
        public string Gerente
        {
            get { return _strGerente; }
            set { _strGerente = value; }
        }

        List<Departamento> ListaDepartamentos = new List<Departamento>();

        public void InsertarDepartamento(Departamento d)
        {
            ListaDepartamentos.Add(d);
        }

        public IEnumerator<Departamento> GetEnumerator()
        {
            return ListaDepartamentos.GetEnumerator();
        }

        ~Empresa()
        {
            ListaDepartamentos.Clear();
        }
    }
}
