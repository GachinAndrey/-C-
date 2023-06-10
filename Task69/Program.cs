/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8
*/

Console.WriteLine("Введите целое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());


int degree = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {degree}");



/*
int Degree(int numA, int numB)
{
     if (numB == 0) return 1;
     return numA * Degree(numA, numB-1); //A 3 3 3 3 3   B 5 4 3 2 1
}
*/

int Degree(int numA, int numB)
{
    return numB == 0 ? 1 : numA * Degree(numA, numB - 1);
}