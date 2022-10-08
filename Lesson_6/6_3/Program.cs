// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
string y = "";
while (a > 0)
{
    y = Convert.ToString(a % 2) + y;
    a = a / 2;
}
Console.WriteLine($"{y} ");