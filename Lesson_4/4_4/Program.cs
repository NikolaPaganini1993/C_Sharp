// 2. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Решение 1.
// void Random01Array(int num)
// {
//     int[] array = new int[num];
//     for(int i=0; i<num; i++)
//     {
//         array[i]=new Random().Next(0,2);
//         Console.Write($"{array[i]} ");
//     }
// }
// Random01Array(8);

// Решение 2.
// int [] array = new int [8];
// void FillArray(int[] number)
// {
//     int length = number.Length;
//     int index = 0;
//     while (index < length)
//     {
//         number[index] = new Random().Next(0,2);
//         index++;
//     }  
// }
// void Random01Array(int[] num)
// {
//     int count = num.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($" {num[position]}");
//         position++;
//     }
   
// }
// FillArray(array);
// Random01Array(array);
