// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next( 0, 9);
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
int[] arr = new int[5];
FillArray(arr);
PrintArray(arr);
int help = 0;
int i = 0;
int c = 1;
while (i < arr.Length / 2)
{
    help = arr[i];
    arr[i] = arr[arr.Length - c];
    arr[arr.Length - c] = help;
    i++;
    c++;
}
Console.WriteLine();
PrintArray(arr);