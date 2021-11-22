using System;
using System.Collections.Generic;
using System.Text;

namespace ProductosCongelados
{
    //DECLARAMOS LA HERENCIA CON LA CLASE PADRE
    class Nitrogeno:Congelado
    {
        public Nitrogeno()
        {
        }
        public int Ingresonitrogeno()
        {
            //APLICAMOS PARA PODER INGRESAR LOS DATOS A LA CLASE
            int tiempoexposicion = int.Parse(Console.ReadLine());
            return tiempoexposicion;
            int peso = int.Parse(Console.ReadLine());
            return peso;
        }
    }
}
