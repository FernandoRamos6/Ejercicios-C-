
int value1 = 34;
Console.WriteLine("Primer valor es: " + value1);
Console.WriteLine("Digite un numero: ");
int value2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(value2);
int resultado = value1 + value2;
Console.WriteLine("La suma es: " + resultado);


Console.WriteLine("Introduzca su nombre: ");
string name = Console.ReadLine();
Console.WriteLine("El nombre ingresado es: "+ name);
Console.ReadKey();

Console.WriteLine("Introduzca su edad: ");
int age = Convert.ToInt32(Console.ReadLine());  //Convierte la entrada a entero
Console.WriteLine("La edad ingresada es: " + age);

Console.WriteLine("Ingrese su salario:");
double pay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El salario ingresado es:" + pay);


{
    Console.WriteLine("Hola"); 
}