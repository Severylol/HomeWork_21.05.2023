Console.Clear();
Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine()!);
    int digitCount = 0;
    int tempNumber = number;
while (tempNumber > 0)
{
    digitCount++;
    tempNumber /= 10;
}
if (digitCount >= 3)
{
    int thirdDigit = (number / (int)Math.Pow(10, digitCount - 3)) % 10;
Console.WriteLine("Третья цифра: " + thirdDigit);
}
else
{
Console.WriteLine("Третьей цифры нет.");
}