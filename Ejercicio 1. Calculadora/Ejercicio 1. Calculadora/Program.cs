//Calculator
using System.Xml;


//while (answer != 1 && answer != 2 && answer != 3 && answer != 4 && answer != 5);

Console.WriteLine("*****CALCULATOR MENU*****");
Console.WriteLine("1.Sumar \n2.Restar \n3.Multiplicar \n4.Dividir \n5.Close program");
Console.WriteLine("Select a option..");
int answer = Convert.ToInt32(Console.ReadLine());

static double suma (double a, double b)
{
    return a + b;
}

static double resta (double a, double b) 
{
    return a - b;
}

static double mult(double a, double b)
{
    return a * b;
}

static double div(double a, double b)
{
    return a / b;
}



    if (answer == 1)
    {
        Console.WriteLine("Enter the value 1");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value 2");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = suma(a, b);
        Console.WriteLine("The result is: " + result);
    }

    if (answer == 2)
    {
        Console.WriteLine("Enter the value 1");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value 2");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = resta(a, b);
        Console.WriteLine("The result is: " + result);
    }

    if (answer == 3)
    {
        Console.WriteLine("Enter the value 1");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value 2");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = mult(a, b);
        Console.WriteLine("The result is: " + result);
    }

    if (answer == 4)
    {
        Console.WriteLine("Enter the value 1");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value 2");
        double b = Convert.ToDouble(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Select a valid value");
            return;
        }
        double result = div(a, b);
        Console.WriteLine("The result is: " + result);
    }

    if (answer == 5)
    {
        Console.WriteLine("Exiting program.. ");
    }  
Console.ReadKey();
