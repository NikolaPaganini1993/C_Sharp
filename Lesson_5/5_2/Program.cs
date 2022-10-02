// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next( -9, 10);
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
void PlusMinus (int[] array2)
{
    int count = 0;
    while (count < array2.Length)
    {
        array2[count]=-array2[count];
        count++;
    }
}
int [] arr = new int[4];
FillArray(arr);
PrintArray(arr);
PlusMinus(arr);
Console.WriteLine();
PrintArray(arr);