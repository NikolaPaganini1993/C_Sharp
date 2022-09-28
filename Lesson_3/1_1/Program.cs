Console.Clear();

// int[] array = new int[4] {1, 2, 3, 4};
// int[] array = {1, 2, 3, 4};
// string[] array = {"Mocsow", "SPB", "Sochi"};

int[] array = {1, 2, 3, 4};

Console.WriteLine($"Число: {array[array.Length - 1]}");

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * 2;
    Console.WriteLine($"Число: {array[i]}");
}


