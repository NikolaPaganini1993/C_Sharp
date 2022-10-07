// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next( -99, 99);
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
    int sum = 0;
    for (int i = 0; i < array3.Length; i += 2)
    {
        sum += array3[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}
int[] arr = new int[4];
FillArray(arr);
PrintArray(arr);
Search(arr);