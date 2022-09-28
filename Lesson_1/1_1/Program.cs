// Напишите программу, которая на входе принимает число и выдаёт его квадрат.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Результат: {result}");

if (num  == result)
{
    Console.WriteLine($"Не может такого быть!");
}
else
{
    Console.WriteLine($"Да");
}
