/* Задача 27. Напишите программу, которая принимает на вход 
число и выдает сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int len = CountNumber(number);
Console.Write($"Сумма цифр в числе {number} -> {SumNumber(number, len)}");

int CountNumber(int num)
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}


int SumNumber(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}