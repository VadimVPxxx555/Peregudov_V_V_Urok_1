﻿Console.Clear();
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number1 < number2)
{
    max = number2;
}
else
{
   max = number1;
}


if (number3 < max)
{
    
}
else
{
   max = number3;
}

Console.WriteLine ($"max = {max}");
