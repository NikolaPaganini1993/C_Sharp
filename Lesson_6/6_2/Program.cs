// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A + B > C && A + C > B && B + C > A)
{
    Console.WriteLine("Треугольник с такими сторонами может быть");
}
else
{
    Console.WriteLine("Треугольника с такими сторонами не может быть");
}