// See https://aka.ms/new-console-template for more information
int a;
int b;
int c;
int opc = 0;


Console.WriteLine("Ingrese un primer valor: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un tercer valor: ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1. Verificar suma \n2. Salir");
opc = Convert.ToInt32(Console.ReadLine());

switch (opc)
{
    case 1:
        if (a + b == c || a + c == b || b + c == a)
        {
            Console.WriteLine("Son iguales");

        }
        else
        {
            Console.WriteLine("Son distintos");
        }
        break;
    case 2:
        if (opc == 2)
        {
            Console.WriteLine("Adios");
        }
        break;
    default:
        Console.WriteLine("Elija una opcion valida");
        break;

}