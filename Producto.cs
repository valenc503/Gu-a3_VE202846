﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejemplo5_VE202846
{
    class Producto
    {
        protected string foto; //URL de foto seleccionada para empleado

        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        string imagen;
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

       

    }
}

