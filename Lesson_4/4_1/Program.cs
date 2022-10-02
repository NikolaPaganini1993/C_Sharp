// 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Решение 1.
// Console.Clear();
// Console.WriteLine("Введите A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i <= A; i++)
// {
// 	result += i;
// }
// Console.WriteLine(result);

// Решение 2.
// Console.Write("Введите A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// int sum = 0;
// while (A >= x)
// {
//     sum = sum + x;
//     x++;
// }
// Console.WriteLine(sum);

// Решение 3.
// int Sum (int num)
// {
//     int all_sum = 0;
//     for (int i = 1; i <= num; i++)
//          all_sum += i;
//     return all_sum;
// }
// Console.WriteLine(Sum(7));