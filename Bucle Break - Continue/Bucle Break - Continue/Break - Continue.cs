
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;      //Rompe el bucle
    }
    Console.WriteLine("Vuelta " + i);
}


for (int i = 0; i <= 10; i++)
{
    if (i == 5)
    {
        continue;      //Rompe el bucle
    }
    Console.WriteLine("Vuelta " + i);
}


int f = 0;
while (f < 10)
{
    Console.WriteLine("Vuelta " + f);
    f++;
    if (f == 7)
    {
        break;
    }
}



Console.ReadKey();