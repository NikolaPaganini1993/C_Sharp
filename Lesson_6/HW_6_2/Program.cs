﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double SearchX (double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 1);
    return x;
}
double SearchY (double b1, double b2, double k1, double k2)
{
    double x = SearchY (b1, b2, k1, k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 1);
    return y;
}

Console.Write("Введите b1: ");
double b1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToUInt32(Console.ReadLine());

if (k1 == k2 && b1 != b2)
Console.WriteLine("Данные прямые параллельны друг другу");
else if (k1 == k2 && b1 == b2)
Console.WriteLine("Данные прямые совпадают");
else
{
    double x = SearchX (b1, b2, k1, k2);
    double y = SearchY (b1, b2, k1, k2);
    Console.WriteLine($"Данные прямые пересекаются в точке: ({x};{y})");
}