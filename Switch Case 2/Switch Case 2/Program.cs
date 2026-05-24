int nota = 70;

string respuesta = nota switch
{
    >= 80 => "Pasaste el examen",
    >= 60 => "Intenta otra vez",
    _ => "Reprobaste"
};
Console.WriteLine(respuesta);