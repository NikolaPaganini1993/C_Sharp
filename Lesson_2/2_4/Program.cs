﻿/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

int x = new Random().Next(10, 20);
Console.WriteLine(x);
int y = new Random().Next(10, 20);
Console.WriteLine(y);
Console.WriteLine($"{y} делится на {x}");
 if (x % y == 0)
    Console.WriteLine ("кратно");
    else
    {
        Console.WriteLine ($"не кратно, остаток: {x % y}");
    }