/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите натуральное число");
int number = 0;
bool res = int.TryParse(Console.ReadLine(), out number);
if (res == false || number <= 0)
{
    Console.WriteLine("Вы ввели не натуральное число!");
}
else NaturalNumbers(number);




void NaturalNumbers(int num) //0
{
    if (num == 0) return;
    Console.Write($"{num}");
    NaturalNumbers(num - 1);
}