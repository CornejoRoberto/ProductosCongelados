using System;
using System.Collections.Generic;
using System.Text;

namespace ProductosCongelados
{
    class Aire:Congelado
    {
        
        public Aire()
            {
            }
        public int ingresoaporcentaje()
        {
            //APLICAMOS PARA PODER INGRESAR LOS DATOS A LA CLASE

            int porcentajeoxigeno = int.Parse(Console.ReadLine());
            return porcentajeoxigeno;
            int porcentajcarbono= int.Parse(Console.ReadLine());
            return porcentajcarbono;
            int porcentajnitrogeno= int.Parse(Console.ReadLine());
            return porcentajnitrogeno;
        }

    }
}
