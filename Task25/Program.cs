/* Задача 25. Напишите цикл, который принимает на вход
два числа(А и В) и возводит число А в натуральную степень В.

3, 5 -> 243 (3**5)
2, 4 -> 16
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {numberA} в степени {numberB} = {Math.Pow(numberA, numberB)}"); // решение 1

Console.WriteLine($"Число {numberA} в степени {numberB} = {Exponentiation(numberA, numberB)}"); // решение 2

int Exponentiation(int x, int power)
{
    int result;
    int i;
    result = 1;
    for (i = 1; i <= power; i++)
    {
        result = result * x;
    }
    return (result);
}