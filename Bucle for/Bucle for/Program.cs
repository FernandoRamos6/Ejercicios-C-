
for(int i = 1; i <= 10; i++ )
{
    Console.WriteLine($"Numero de vuelta: { i }");
}

Console.WriteLine("Fin del bucle");




for (int f = 1; f <= 10; f+=2)  //Aqui en lugar de 1 en 1 va de 2 en 2
{
    Console.WriteLine($"Numero de vuelta: {f}");
}

Console.WriteLine("Fin del bucle");


const int y = 3;

for (int vueltas = 0; vueltas <= 10; vueltas++)
{
    Console.WriteLine($"{y} X {vueltas} = {y * vueltas}");
}
Console.WriteLine("Finde la tabla");



Console.ReadKey();