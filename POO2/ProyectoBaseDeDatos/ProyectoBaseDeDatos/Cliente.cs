using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDeDatos
{
    class Cliente
    {
        public Cliente(string _strNombreConstructora, string _strTelefonoConstructora, string _strCorreoElectronicoConstructura, string _strNombreContactoConstructora, string _strDireccionConstructora)
        {
            this._intIdCliente = 0;
            this._strNombreConstructora = _strNombreConstructora;
            this._strTelefonoConstructora = _strTelefonoConstructora;
            this._strCorreoElectronicoConstructura = _strCorreoElectronicoConstructura;
            this._strNombreContactoConstructora = _strNombreContactoConstructora;
            this._strDireccionConstructora = _strDireccionConstructora;
        }

        public Cliente(int _intIdCliente, string _strNombreConstructora, string _strTelefonoConstructora, string _strCorreoElectronicoConstructura, string _strNombreContactoConstructora, string _strDireccionConstructora, int _intCompras)
        {
            this._intIdCliente = _intIdCliente;
            this._strNombreConstructora = _strNombreConstructora;
            this._strTelefonoConstructora = _strTelefonoConstructora;
            this._strCorreoElectronicoConstructura = _strCorreoElectronicoConstructura;
            this._strNombreContactoConstructora = _strNombreContactoConstructora;
            this._strDireccionConstructora = _strDireccionConstructora;
            this._intCompras = _intCompras;
        }

        private int _intIdCliente;

        public int IdCliente
        {
            get { return _intIdCliente; }
            set { _intIdCliente = value; }
        }

        private string _strNombreConstructora;

        public string NombreConstructora
        {
            get { return _strNombreConstructora; }
            set { _strNombreConstructora = value; }
        }

        private string _strTelefonoConstructora;

        public string TelefonoConstructora
        {
            get { return _strTelefonoConstructora; }
            set { _strTelefonoConstructora = value; }
        }

        private string _strCorreoElectronicoConstructura;

        public string CorreoElectronicoConstructora
        {
            get { return _strCorreoElectronicoConstructura; }
            set { _strCorreoElectronicoConstructura = value; }
        }

        private string _strNombreContactoConstructora;

        public string NombreContactoConstructora
        {
            get { return _strNombreContactoConstructora; }
            set { _strNombreContactoConstructora = value; }
        }

        private string _strDireccionConstructora;

        public string DireccionConstructora
        {
            get { return _strDireccionConstructora; }
            set { _strDireccionConstructora = value; }
        }

        private int _intCompras;

        public int Compras
        {
            get { return _intCompras; }
            set { _intCompras = value; }
        }

    }
}
