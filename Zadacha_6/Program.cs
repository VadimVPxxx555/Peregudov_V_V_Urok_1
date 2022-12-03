Console.Clear();
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
double z =  number1 % 2;

if (z == 0)
{
    Console.WriteLine ($"{number1} четное");
}
else
{
    Console.WriteLine ($"{number1} нечетное");
}

