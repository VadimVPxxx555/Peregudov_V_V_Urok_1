Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int number1 = 0;

while((number1 + 2) < number)
{
    number1 = number1 + 2;
    Console.Write ($"{number1}, ");
}
Console.Write ($"{number}.");

