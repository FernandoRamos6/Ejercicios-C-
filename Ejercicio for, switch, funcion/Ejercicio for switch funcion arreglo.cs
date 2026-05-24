using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
//Muestre un menú con las siguientes opciones:
//1Capturar calificaciones
//2Mostrar promedio
//3Mostrar la calificación mayor
//4Salir
int opcion;
int[] calificaciones = new int[5]; //declara el arreglo por fuera para que no se reinicie
do
{
    Console.WriteLine("***MENU***");
    Console.WriteLine();
    Console.WriteLine("1. Capturar calificaciones \n2. Mostrar promedio \n3. Mostrar calificacion mayor \n4. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Ingrese las calificaciones ");
                calificaciones[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 1; j < calificaciones.Length; j++)
            {
                Console.WriteLine("Calificacion " + j + ": " + calificaciones[j]);
            }
            break;

        /*
        static int SumarArreglo(int[] arreglo)
        {
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }
            return suma;
        }
        */

        case 2:
            {
                double promedio;
                int suma = 0;
                for (int i = 0; i < calificaciones.Length; i ++)
                {
                    suma += calificaciones[i];
                }
                promedio = suma / calificaciones.Length;

                Console.WriteLine("El promedio de calificaciones es: " + promedio);
            }
            break;

        case 3:
            {
                Console.WriteLine("La calificacion mayor es: " + calificaciones.Math.max)
            }
            break;
        default:
            { 
                Console.WriteLine("Ingrese una opcion valida.. ");
            }
            break;
    }
} while (opcion != 4);
Console.WriteLine("Saliendo del programa...");
Console.ReadKey();