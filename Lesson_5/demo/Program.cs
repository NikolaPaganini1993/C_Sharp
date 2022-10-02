// int x = 3;
// int y = 2;
// if(x > y + 2)
// {
//     Console.WriteLine($"{x} больше");
// }
// else Console.WriteLine($"{y} больше");

// int x1 = 3;
// int y1 = 7;
// if(x1 > y1)
// {
//     Console.WriteLine($"{x1} больше");
// }
// else Console.WriteLine($"{y1} больше");

// int x3 = 17;
// int y3 = 5;
// if(x3 > y3)
// {
//     Console.WriteLine($"{x3} больше");
// }
// else Console.WriteLine($"{y3} больше");

// Четыре вида методов (функций):

// 1. Void. Не возвращает.
// Пример:

// void HelloWorld(string name)
// {
//     Console.WriteLine($"Привет, {name}!!!");
// }
// string q = "Bob";
// HelloWorld(q);
// string a = "Ann";
// HelloWorld(a);
// string z = "Alice";
// HelloWorld(z);

// void MaxNum(int x, int y)
// {
// if(x > y)
// {
//     Console.WriteLine($"{x} больше");
// }
// else Console.WriteLine($"{y} больше");
// }
// int xx = 3;
// int yy = 2;
// MaxNum(xx, yy);

// 2. Возвращает. (какой тип данных? int ... return ...)

int MaxNum(int x, int y)
{
if(x > y)
{
    return x;
}
else return y;
}
int xx = 3;
int yy = 2;
int maxn = MaxNum(xx, yy);
Console.WriteLine($"{maxn} больше");