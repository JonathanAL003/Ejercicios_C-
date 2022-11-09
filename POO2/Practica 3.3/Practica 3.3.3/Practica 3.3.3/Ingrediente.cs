using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3._3._3
{
    class Ingrediente
    {
        private string _strNombreIngrediente, _strUnidadDeMedida;
        private double _dblCantidad, _dblCaloriasPorPorcion;

        public string NombreIngrediente
        {
            get { return _strNombreIngrediente; }
            set { _strNombreIngrediente = value; }
        }
        public string UnidadDeMedida
        {
            get { return _strUnidadDeMedida; }
            set { _strUnidadDeMedida = value; }
        }
        public double Cantidad
        {
            get { return _dblCantidad; }
            set { _dblCantidad = value; }
        }
        public double CaloriasPorPorcion
        {
            get { return _dblCaloriasPorPorcion; }
            set { _dblCaloriasPorPorcion = value; }
        }
    }
}
