/*Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdDigit(number);
Console.WriteLine($"{number} -> {result}");

int ThirdDigit(int num)
{
    int result = 0;
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;

    }
    else if (num < -99)
    {
        num = num * -1;
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    else
    {
        Console.WriteLine($"Третьей цифры нет");
    }
    return result;
}
