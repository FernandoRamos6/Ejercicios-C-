using System.ComponentModel.Design;

Console.WriteLine("Enter a number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number");
int num3 = Convert.ToInt32(Console.ReadLine());

int major;

if (num1 >= num2 && num1 >= num3)
{
    major = num1;
}
else if (num2 >= num1 && num2 >= num3)
{
    major = num2;
}

else
{
    major = num3;
}
Console.WriteLine("The major number is: " + major);