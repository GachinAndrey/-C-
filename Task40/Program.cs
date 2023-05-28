/*Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

Console.WriteLine("Введите длину стороны А треугольника: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны В треугольника: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны С треугольника: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool existTriangle = IsExistTriangle(numberA, numberB, numberC);
Console.WriteLine(existTriangle ? "Существует" : "Не существует");

bool IsExistTriangle(int a, int b, int c)
{
    return a + b > c && b + c > a && a + c > b;
}