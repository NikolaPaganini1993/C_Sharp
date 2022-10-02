// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next( -100, 100);
        index++;
    }
}
void PrintArray(int[] array1)
{
    int count = array1.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{array1[pos]} ");
        pos++;
    }
}
void Search(int[] Array2, int Num)
{
    int count = 0;
    int real = 0;
    while (count < Array2.Length)
    {
        if (Array2[count] == Num)
        {
            real = 1;
        }
        count++;
    }
    if (real == 1)
    {
        Console.WriteLine("Это число есть в массиве");
    }
    else
    {
        Console.WriteLine("Этого числа нет в массиве");
    }
}
int [] Arr = new int [5];
FillArray(Arr);
Console.WriteLine("Введите число для поиска: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(Arr);
Search(Arr, N);
