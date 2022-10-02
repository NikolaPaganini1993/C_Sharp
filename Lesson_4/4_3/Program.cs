// 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Решение 1.
// int Factorial(int num)
// {
//     int AllSum = 1;
//     for (int i = 1; i <= num; i++)
//         AllSum = AllSum * i;
//     return AllSum;
// }
// Console.WriteLine(Factorial(4));
// Console.WriteLine(Factorial(5));

// // Решение 2.
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// int multiplication = 1;
// while (N >= x)
// {
//     multiplication = multiplication * x;
//     x++;
// }
// Console.WriteLine(multiplication);