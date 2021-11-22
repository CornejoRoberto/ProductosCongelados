using System;
using System.Collections.Generic;
using System.Text;

namespace ProductosCongelados
{
    class Nitrogeno:Congelado
    {
        public Nitrogeno()
        {
        }
        public int Ingresonitrogeno()
        {

            int tiempoexposicion = int.Parse(Console.ReadLine());
            return tiempoexposicion;
            int peso = int.Parse(Console.ReadLine());
            return peso;
        }
    }
}
