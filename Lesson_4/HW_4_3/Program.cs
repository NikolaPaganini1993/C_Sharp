// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];
void FillArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        number[index] = new Random().Next(0,100);
        index++;
    }  
}

void Random01Array(int[] num)
{
    int count = num.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {num[position]}");
        position++;
    }
   
}
FillArray(array);
Random01Array(array);
