using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5_VE202846
{
    class Clientebanco
    {
        //atributos
        private string dui;
        private string nombre;
        private string apellido;
        private string tipocuenta;
        private string nit;
        private string numerocuenta;
        private string monto;
        private string sucursal;
        //métodos

        public string Dui
        {
            get { return dui; }
            set { dui = value; }

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string TipoCuenta
        {
            get { return tipocuenta; }
            set { tipocuenta = value; }
        }
        public string Nit
        {
            get { return nit; }
            set { nit = value; }
        }

        public string NumeroCuenta
        {
            get { return numerocuenta; }
            set { numerocuenta = value; }
        }

        public string Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
    }
}
