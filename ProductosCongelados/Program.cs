using System;
using System.Collections.Generic;

namespace ProductosCongelados
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Ingrese el nombre de su producto");
            Ingreso ingreso = new Ingreso();
            String Nombre = ingreso.IngresoNombre();
            Console.WriteLine("Ingrese el tipo de su producto");
            String Tipo = ingreso.IngresoNombre();
            Console.Write("Su producto agregado fue: " + Nombre + "\n" + "El tipo de su producto es: " + Tipo+"\n");
            Console.WriteLine("Seleccione su metodo de congelacion mediante el menu de:");
            Console.Write("Congelación por aire #1"+"\n" + "Congelación por agua #2"+"\n"+"Congelación por nitrógeno #3"+"\n");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                int producto;
                Console.WriteLine("Ingrese su porcentaje de oxigeno en números enteros");
                Aire aire = new Aire();
                int porcentajeoxigeno = aire.ingresoaporcentaje();
                aire.porcentajeoxigeno = porcentajeoxigeno;
                Console.WriteLine("Ingrese su porcentaje de carbono en números enteros");
                Aire carbono = new Aire();
                int porcentajcarbono = aire.ingresoaporcentaje();
                carbono.porcentajeoxigeno = porcentajcarbono;
                Console.WriteLine("Ingrese su porcentaje de nitrogeno en números enteros");
                Aire nitrogeno = new Aire();
                int porcentajnitrogeno = aire.ingresoaporcentaje();
                nitrogeno.porcentajeoxigeno = porcentajnitrogeno;
                List<Aire> Listaporcentajes = new List<Aire>();
                Listaporcentajes.Add(aire);
                Listaporcentajes.Add(carbono);
                Listaporcentajes.Add(nitrogeno);
                foreach (Aire item in Listaporcentajes)
                {
                    Console.WriteLine("Se tiene un % de :"+item.porcentajeoxigeno+"% respectivamente.");
                }
                producto = (porcentajcarbono * porcentajeoxigeno * porcentajnitrogeno);
                Console.WriteLine("El resultado de la multiplicacion de estos porcentajes da un valor de:"+producto+"%");
            }
            else if (num1==2)
            {
                int producto2;
                Console.WriteLine("Ingrese su cantidad de gramos de sal en enteros");
                Agua agua = new Agua();
                int gramossal = agua.Ingresoaguaporcen();
                Console.WriteLine("Ingrese su cantidad de litros de agua en números enteros");
                int litrosdeagua = agua.Ingresoaguaporcen();
                List<Agua> Listagua = new List<Agua>();
                Listagua.Add(agua);
                foreach (Agua item in Listagua)
                {
                    Console.WriteLine("La cantidad de gramos de sal es: "+gramossal +"\n"+"La cantidad de litros de agua es: "+litrosdeagua);
                }
                producto2 = (gramossal * litrosdeagua);
                Console.WriteLine("El resultado de la multiplicacion de los gramos de sal necesario para los litros de agua son: " + producto2);
            }
            else if (num1 == 3)
            {
                int producto3;
                Console.WriteLine("Ingrese su tiempo de exposicion al nitrógeno");
                Nitrogeno nitro = new Nitrogeno();
                int tiempoexposicion = nitro.Ingresonitrogeno();
                Console.WriteLine("Ingrese el peso del producto");
                int peso = nitro.Ingresonitrogeno();
                List<Nitrogeno> Listanitro= new List<Nitrogeno>();
                Listanitro.Add(nitro);
                foreach (Nitrogeno item in Listanitro)
                {
                    Console.WriteLine("El tiempo de exposición fue de " + tiempoexposicion + " minutos"+ "\n" + "El peso del producto es de: " + peso);
                }
                producto3 = (tiempoexposicion * peso);
                Console.WriteLine("El resultado de la multiplicación de su tiempo de exposición mas su peso fue de: " + producto3);


            }
        }
    }
}
