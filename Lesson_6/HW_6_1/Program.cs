// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int HowManyPositive(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temporary = 0;
        temporary = Convert.ToInt32(Console.ReadLine());
        array[i] = temporary;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) positive++;
    }
    return positive;
}
Console.Write("Сколько цифр вы собираетесь написать: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int positive = HowManyPositive(array);
Console.WriteLine($"Количество положительных чисел: {positive}");