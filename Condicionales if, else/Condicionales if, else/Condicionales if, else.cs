
Console.WriteLine("Nota final del alumno");
int nota = 47;


if (nota > 70)
{
    Console.WriteLine("Felicidades pasaste el examen");
}
else if (nota < 70 && nota > 50)    //Operador Y para evaluar las dos condiciones  else if funciona como elif
{
    Console.WriteLine("Debes repetir el examen");
}

else
{
    Console.WriteLine("Reprobaste");
}









    Console.ReadKey();