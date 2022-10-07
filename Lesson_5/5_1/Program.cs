// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] number)
{
    int index = 0;
    while (index < number.Length)
    {
        number[index] = new Random().Next( -9, 10);
        index++;
    }
}
void PrintArray(int[] narray)
{
    int count = narray.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{narray[pos]} ");
        pos++;
    }
}
void Sum (int[] array)
{
    int count = 0;
    int SumMinus = 0;
    int SumPlus = 0;
    while (count < array.Length)
    {
        if (array[count] < 0)
        {
            SumMinus += array[count];
            count++;
        }
        else 
        {
            SumPlus += array[count];
            count++;
        }
    }
    Console.WriteLine($"Сумма отрицательных = {SumMinus}");
    Console.WriteLine($"Сумма положительных = {SumPlus}");
}
int[] arr = new int[12];
FillArray(arr);
PrintArray(arr);
Sum(arr);