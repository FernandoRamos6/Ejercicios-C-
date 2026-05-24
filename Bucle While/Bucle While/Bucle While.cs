/*
int valor = 0;


while (valor <= 3)
{
    Console.WriteLine("El valor es " + valor);
    valor++;
    
}

Console.WriteLine("Fin del bucle");
*/
/*
int numero = 0;
while (numero <= 30)
{
    Console.WriteLine("Valor es: " + numero);
    if (numero == 2)
    {
        Console.WriteLine("Soy la vuelta 2");
    }
    numero++;
}
*/

//EJEMPLO TABLA DE MULTIPLICAR

int numero = 1;
const int valor = 7;
Console.WriteLine("Tabla del: " + valor);
while (numero <= 10) {
    Console.WriteLine($"{ valor} X { numero} = { valor * numero}");
    numero++;
}
Console.WriteLine("Fin de la tabla");


Console.ReadKey();