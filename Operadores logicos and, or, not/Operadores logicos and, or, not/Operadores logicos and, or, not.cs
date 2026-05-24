
int numero1 = 40, numero2 = 90, numero3 = 2;
bool resultado;

//OPERADOR AND  (y)
//Deben cumplirse las dos condiciones para que sea True
resultado = numero1 < numero2 && numero1 < numero3;
Console.WriteLine(resultado);



//OPERADOR OR (o)
//Deben cumplirse al menos una de las dos condiciones para que sea True
resultado = numero1 < numero2 || numero1 < numero3;
Console.WriteLine(resultado);



//OPERADOR NOT (o)
//Deben cumplirse al menos una de las dos condiciones para que sea True
resultado = numero1 < numero2 || numero1 < numero3;
Console.WriteLine(!resultado); //Niega un valor booleano



Console.ReadKey();