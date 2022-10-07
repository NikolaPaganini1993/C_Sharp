// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void FillArray(double[] array)
{
    Random rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = Math.Round(new Random().Next(0, 10) + rnd.NextDouble(), 2);
        index++;
    }
}
void PrintArray(double[] array2)
{
    int count = array2.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{array2[pos]} ");
        pos++;
    }
}
void Search (double[] array3)
{
    double Max = array3[0];
    double Min = array3[0];
    for (int i = 0; i < array3.Length; i++)
    {
        if(array3[i] > Max)
        {
            Max = array3[i];
        }
        else if(array3[i] < Min)
        {
            Min = array3[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Math.Round(Max - Min, 2)}");
}
double[] arr = new double[4];
FillArray(arr);
PrintArray(arr);
Search(arr);