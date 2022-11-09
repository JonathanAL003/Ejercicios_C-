using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_2
{
    class iPhone: Producto
    {
        private string _strHuellaDactilar;

        public string HuellaDactilar
        {
            get { return _strHuellaDactilar; }
            set { _strHuellaDactilar = value; }
        }

        private int _intCantidadCamaras;

        public int CantidadCamaras
        {
            get { return _intCantidadCamaras; }
            set { _intCantidadCamaras = value; }
        }

        private string _strTipoPuerto;

        public string TipoPuerto
        {
            get { return _strTipoPuerto; }
            set { _strTipoPuerto = "lithgning"; }
        }

        List<Chip> ListaChip = new List<Chip>();
        List<Dispositivo> ListaDispositivo = new List<Dispositivo>();

        public void InsertarChip(Chip c)
        {
            ListaChip.Add(c);
        }

        public void AgregarDispositivo(Dispositivo d)
        {
            ListaDispositivo.Add(d);
        }

        //public IEnumerator<Chip> GetEnumerator()
        //{
            //return ListaChip.GetEnumerator();
        //}  

        public IEnumerator<Dispositivo> GetEnumerator()
        {
            return ListaDispositivo.GetEnumerator();
        }

        public override string ToString()
        {
            return "iPhone";
        }

        ~iPhone()
        {
            ListaChip.Clear();
        }
    }
}
