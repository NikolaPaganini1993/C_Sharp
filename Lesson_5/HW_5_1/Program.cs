// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next( 100, 999);
        index++;
    }
}
void PrintArray(int[] array2)
{
    int count = array2.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{array2[pos]} ");
        pos++;
    }
}
void Search (int[] array3)
{
    int index = 0;
    int amount = 0;
    while (index < array3.Length)
    {
        if (array3[index] % 2 == 0)
        {
            amount++;
        }
        index++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве = {amount}");
}
int[] arr = new int[4];
FillArray(arr);
PrintArray(arr);
Search(arr);