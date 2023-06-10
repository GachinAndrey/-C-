/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите натуральное число M:");
int numberM;
bool resM = int.TryParse(Console.ReadLine(), out numberM);
Console.WriteLine("Введите натуральное число N:");
int numberN;
bool resN = int.TryParse(Console.ReadLine(), out numberN);

//if (resM == false || resN == false || numberM <= 0 || numberN <= 0)
//{
//    Console.WriteLine("Вы ввели не натуральное число!");
//}
//else
//{
//    Console.WriteLine($"Сумма элементов: {SumNumbers(numberM, numberN)}");
//}

if (resM == false || numberM <= 0)
{
    Console.WriteLine("Число M не натуральное!");
}
else if (resN == false || numberN <= 0)
{
    Console.WriteLine("Число N не натуральное!");
}
else if (resM == false || resN == false || numberM <= 0 || numberN <= 0)
{
    Console.WriteLine("Вы ввели не натуральные числа!");
}
else
{
    Console.WriteLine($"Сумма элементов: {SumNumbers(numberM, numberN)}");
}


int SumNumbers(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return n + SumNumbers(m, n - 1);
    else return n + SumNumbers(m, n + 1);
}