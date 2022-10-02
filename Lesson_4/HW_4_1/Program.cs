// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение 1.
// Console.Write("Введите A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int Exponentiation = 1;
// while (B >= i)
// {
//     Exponentiation = Exponentiation * A;
//     i++;
// }
// Console.WriteLine(Exponentiation);

// Решение 2.
// Console.Write("Введите A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int Exponentiation(int A, int B)
// {
//   for(int i = 1; i <= B; i++)
//   {
//     result = result * A;
//   }
//   return result;
// }
// Console.WriteLine($"Ответ: {Exponentiation(A, B)}");
