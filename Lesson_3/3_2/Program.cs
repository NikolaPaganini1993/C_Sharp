// // 2. Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой области (x и y).

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if( x == 1)
// {
//     Console.WriteLine("x > 0 и y > 0");
// }
// else if( x == 2)
// {
//     Console.WriteLine("x < 0 и y > 0");
// }
// else if( x == 3)
// {
//     Console.WriteLine("x < 0 и y < 0");
// }
// else if( x == 4)
// {
//     Console.WriteLine("x > 0 и y < 0");
// }
// else if( x < 1 | x > 4)
// {
//     Console.Write("Такой четверти нет.");
// }

Console.Write("Введите четверть от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());
string [] array = {"x = (1;100), y = (1;100)", "x = (-1;-100), y = (1;100)", "x = (-1;-100), y = (-1;-100)", "x = (1;100), y = (-1;-100)"};
Console.Write($"Возможный диапазон координат точек одной четверти для " + array[x-1]);
