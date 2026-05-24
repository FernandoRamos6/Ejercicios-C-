//Crear e imprimir un array
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