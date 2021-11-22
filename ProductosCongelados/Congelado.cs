using System;
using System.Collections.Generic;
using System.Text;

namespace ProductosCongelados
{
    //CREAMOS LA CLASE PADRE QUE HEREDARÁ A LAS CLASES HIJAS QUE SON AGUA, NITROGENO Y AIRE
    class Congelado
    {
        public int porcentajeoxigeno { get; set; }
        public int porcentajcarbono { get; set; }
        public int porcentajnitrogeno { get; set; }
        public int suma { get; set; }
        public int gramossal { get; set; }
        public int litrosdeagua{ get; set; }
        public int peso { get; set; }
        public int tiempoexposicion { get; set; }
    }
}
    

