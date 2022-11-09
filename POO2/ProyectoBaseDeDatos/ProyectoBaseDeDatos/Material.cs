using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDeDatos
{
    class Material
    {
        public Material(string _strNombreMaterial, double _dblCantidadMaterial, double _dblPrecioVentaMaterial)
        {
            this._intIdMaterial = 0;
            this._strNombreMaterial = _strNombreMaterial;
            this._dblCantidadMaterial = _dblCantidadMaterial;
            this._dblPrecioVentaMaterial = _dblPrecioVentaMaterial;
        }

        public Material(int _intIdMaterial, string _strNombreMaterial, double _dblCantidadMaterial, double _dblPrecioVentaMaterial)
        {
            this._intIdMaterial = _intIdMaterial;
            this._strNombreMaterial = _strNombreMaterial;
            this._dblCantidadMaterial = _dblCantidadMaterial;
            this._dblPrecioVentaMaterial = _dblPrecioVentaMaterial;
        }

        public Material(double _dblCantidadMaterial ,double _dblPrecioVentaMaterial)
        {
            this._dblCantidadMaterial = _dblCantidadMaterial;
            this._dblPrecioVentaMaterial = _dblPrecioVentaMaterial;
        }

        private int _intIdMaterial;

        public int IdMaterial
        {
            get { return _intIdMaterial; }
            set { _intIdMaterial = value; }
        }

        private string _strNombreMaterial;

        public string NombreMaterial
        {
            get { return _strNombreMaterial; }
            set { _strNombreMaterial = value; }
        }

        private double _dblCantidadMaterial;

        public double CantidadMaterial
        {
            get { return _dblCantidadMaterial; }
            set { _dblCantidadMaterial = value; }
        }

        private double _dblPrecioVentaMaterial;

        public double PrecioVentaMaterial
        {
            get { return _dblPrecioVentaMaterial; }
            set { _dblPrecioVentaMaterial = value; }
        }
    }
}
