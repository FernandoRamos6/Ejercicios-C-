//Muestra todos los numeros pares entre 1 y 100

using System.IO.Pipelines;

for (int i = 1; i <= 100;) 
{
    i++;
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//Contador hasta cero
//Pide un número al usuario y usa while para contar hacia atrás hasta llegar a 0.
int numero;

do
{
    Console.WriteLine("Ingrese un numero");
    Console.WriteLine("Ingrese 0 para salir");
    numero = Convert.ToInt32(Console.ReadLine());

       if (numero == 0)
    {
        break;
    }
    int contador = numero;

   

    while (contador > 0)
    {
        Console.WriteLine(contador);
        contador--;
    }
    Console.WriteLine();//Espacio entre repeticiones

}
while (true);

