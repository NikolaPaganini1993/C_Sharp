// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int SumNumber(int A)
{
    int count = Convert.ToString(A).Length;
    int number = 0;
    int result = 0;
    for(int i = 0; i < count; i++)
    {
        number = A - A % 10;
        result = result + (A-number);
        A = A / 10;
    }
    return result;
}
int sumNumber = SumNumber(A);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");

