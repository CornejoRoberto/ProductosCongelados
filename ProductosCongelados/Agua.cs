﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductosCongelados
{
    class Agua:Congelado
    {
        public Agua()
        {
        }
        public int Ingresoaguaporcen()
        {
            //APLICAMOS PARA PODER INGRESAR LOS DATOS A LA CLASE

            int gramossal = int.Parse(Console.ReadLine());
            return gramossal;
            int litrosdeagua = int.Parse(Console.ReadLine());
            return litrosdeagua;
        }
    }
}
