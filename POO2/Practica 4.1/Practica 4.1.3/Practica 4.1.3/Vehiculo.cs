using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._1._3
{
    abstract class Vehiculo
    {
        private string _strPlacas;
        private bool _blnAlquilada;

        public string Placas
        {
            get { return _strPlacas; }
            set { _strPlacas = value; }
        }
        public bool Alquilada
        {
            get { return _blnAlquilada; }
            set { _blnAlquilada = value; }
        }

        public abstract double Precio
        { get; set; }

        public virtual string ConsultarDisponibilidad()
        {
            if (Alquilada == true)
            {
                return ("Alquilado");
            }
            if (Alquilada == false)
            {
                return ("Devuelto");
            }
            else
            {
                return ("");
            }
        }
    }
}
