//Crear e imprimir un array
using System.Collections;

int [] numeros = { 1, 2, 3, 4, 5 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}


//Sumar elementos del array
int[] sumatoria = { 20, 34, 98, 10, 36 };
int suma = 0;

for (int i = 0; i < sumatoria.Length; i++)
{ suma += sumatoria[i];
}
Console.WriteLine(suma);
sumatoria.Sort();
Console.WriteLine(sumatoria[4]);
/*
Python C#       con Array	        C# con List
len(lista)	    array.Length	    lista.Count
append()	    ❌ No existe	    Add()
remove()	    ❌	Remove()
sort()	        Array.Sort()	    Sort()
max()	        array.Max() (LINQ)	lista.Max()
*/
