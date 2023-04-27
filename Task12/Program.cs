/* Задача 12. Напишите программу,
которая будет принимать на вход два числа и выводить,
является ли первое число кратным второму.
Если первое число не кратновторому,
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

// Console.WriteLine("Первое число = ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Второе число = ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int remainder = number1 % number2;

// if (remainder == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {remainder} ");
// }

Console.WriteLine("Первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
string result = remainder != 0 ? $"Не кратно, остаток {remainder} " : "Кратно";
Console.WriteLine(result);

int Remainder(int num1, int num2)
{
    return num1 % num2;
}