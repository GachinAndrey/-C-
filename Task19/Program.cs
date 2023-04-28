/* Задача 19 Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).

14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number < 100000)
{
    int reverse = Reverse(number);
    bool palindromNumber = PalindromNumber(number, reverse);
    Console.WriteLine(palindromNumber == true ? $"{number} -> Да" : $"{number} -> Нет");
}
else if (number > -100000 && number <= -10000)
{
    int reverse = Reverse(number * -1);
    bool palindromNumber = PalindromNumber(number * -1, reverse);
    Console.WriteLine(palindromNumber == true ? $"{number} -> Да" : $"{number} -> Нет");
}
else
{
    Console.WriteLine("Число не пятизначное!");
}

int Reverse(int num)
{
    int reverse = 0;
    while (num > 0)
    {
        int remainder = num % 10;
        reverse = (reverse * 10) + remainder;
        num = num / 10;
    }
    return reverse;
}

bool PalindromNumber(int num, int rev)
{
    if (num == rev) return true;
    return false;
}