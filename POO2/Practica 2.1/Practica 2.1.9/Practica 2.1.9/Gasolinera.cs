using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._9
{
    class Gasolinera
    {
        private double _dblPesos, _dblGalones, _dblPrecioLitro;

        public double Pesos
        {
            get { return _dblPesos; }
            set { _dblPesos = value; }
        }

        public double Galones
        {
            get { return _dblGalones; }
            set { _dblGalones = value; }
        }
        
        public double PrecioLitro
        {
            get { return _dblPrecioLitro; }
            set { _dblPrecioLitro = value; }
        }

        public Gasolinera(double PrecioLitro)
        {
            _dblPrecioLitro = PrecioLitro;
        }

        public string CalcularFactura()
        {
            return ("Son: " + Math.Round((Galones*3.785),2) + " litros \n" +
                "El precio de gasolina por litro es de $"+ PrecioLitro +
                "\n\nSu factura es de $" + Math.Round(((Galones*3.785)*PrecioLitro),2) + " pesos.");
        }
    }
}
