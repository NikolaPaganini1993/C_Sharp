// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray(int[] array)
// {
//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         array[index] = new Random().Next( -100, 100);
//         index++;
//     }
// }
// void PrintArray(int[] array1)
// {
//     int count = array1.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.Write($"{array1[pos]} ");
//         pos++;
//     }
// }
// void Search(int[] array2)
// {
//     int count = 0;
//     int index = 0;
//     while(index <array2.Length)
//     {
//         if (array2[count] >= 10; array2[count] <= 99)
//         {
//             count++;
//             index++;
//         }
//         else
//         {
//             index++;
//         }
//     }
// }