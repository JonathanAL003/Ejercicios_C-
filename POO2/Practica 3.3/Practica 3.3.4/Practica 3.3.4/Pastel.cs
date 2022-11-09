using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._3._4
{
    class Pastel
    {
        private string _strNombrePastel;
        private int _intCantidadDePersonas;
        private double _dblPrecio;

        public string NombrePastel
        {
            get { return _strNombrePastel; }
            set { _strNombrePastel = value; }
        }
        public int CantidadDePersonas
        {
            get { return _intCantidadDePersonas; }
            set { _intCantidadDePersonas = value; }
        }
        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        List<Ingrediente> ListaIngredientes = new List<Ingrediente>();

        public void AgregarIngrediente(Ingrediente i)
        {
            ListaIngredientes.Add(i);
        }

        public IEnumerator<Ingrediente> GetEnumerator()
        {
            return ListaIngredientes.GetEnumerator();
        }

        public override string ToString()
        {
            return NombrePastel;
        }

        public int ContarIngredientes()
        {
            return ListaIngredientes.Count;
        }

        public double SumarCalorias()
        {
            double suma = 0.0;
            foreach (Ingrediente unIngrediente in ListaIngredientes)
            {
                suma += unIngrediente.CaloriasPorPorcion;
            }
            return suma;
        }
    }
}
