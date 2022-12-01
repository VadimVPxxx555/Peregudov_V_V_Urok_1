Console.Clear();
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
double z =  number1 % 2;

if (z < 1)
{
    Console.WriteLine ($"{number1} четное");
}
else
{
    Console.WriteLine ($"{number1} нечетное");
}

