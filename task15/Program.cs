Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблиись, в неделе 7 дней!\nВведите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n == 1)
    Console.WriteLine("Будний день - Понедельник");
else if (n == 2)
    Console.WriteLine("Будний день - Вторник");
else if (n == 3)
    Console.WriteLine("Будний день - Среда");
else if (n == 4)
    Console.WriteLine("Будний день - Четверг");
else if (n == 5)
    Console.WriteLine("Будний день - Пятница");
else if (n == 6)
    Console.WriteLine("Сегодня выходной - Суббота");
else
    Console.WriteLine("Сегодня выходной - Воскресенье");
