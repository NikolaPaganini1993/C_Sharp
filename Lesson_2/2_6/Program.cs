/* 5) Напиши программу, которая по введённому возрасту пользователя сообщает, к какой возрастной группе он относится:
	до 13 включительно – детство;
	от 14 до 24 – молодость;
	от 25 до 59 – зрелость;

от 60 – старость.
*/

Console.Write("Ваш возраст: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x <= 13)
{
    Console.WriteLine("Детство");
}
else if(x <= 24)
{
    Console.WriteLine("Юность");
}
else if(x <= 59)
{
    Console.WriteLine("Зрелость");
}
else if(x >= 60)
{
    Console.WriteLine("Старость");
}
