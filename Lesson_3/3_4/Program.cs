// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//    5 -> 1,4,9,16,25.
//    2 -> 1,4

Console.Clear();
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number = 1;
while (count <= N)
{
    number = count * count;
    count++;
    Console.Write($"{number} ");
}