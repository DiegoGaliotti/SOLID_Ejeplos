﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O_OpenClose
{
    internal class Producto
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Producto(double precio, string descripción)
        {
            Precio = precio;
            Descripcion = descripción;
        }
    }
}
