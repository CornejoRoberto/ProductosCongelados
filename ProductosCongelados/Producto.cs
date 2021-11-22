using System;
using System.Collections.Generic;
using System.Text;

namespace ProductosCongelados
{
    public class Producto
    {
       
        public Producto(string Nombre, string Tipo)
        {
        this.Nombre = Nombre;
        this.Tipo= Tipo;

        }

        public string Nombre { get; }
        public string Tipo { get; }

    }
}
