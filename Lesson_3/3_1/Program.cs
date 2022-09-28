// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X не равен 0 и Y не равен 0
//    и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if( x == 0 | y == 0)
{
    Console.WriteLine("Введите другую коордиинату");
}
else if( x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if( x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if( x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if( x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}