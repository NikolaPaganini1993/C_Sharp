// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//    3 -> 1, 8, 27
//    5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number = 1;
while (count <= N)
{
    number = count * count * count;
    count++;
    Console.Write($"{number} ");
}