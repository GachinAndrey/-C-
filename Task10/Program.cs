/* Задача 10: Напишите программу,
которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = ShowSecondNumber(number);
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine($"Число {number} не трёхзначное");
}

int ShowSecondNumber(int num)
{
    int secondDigit = num % 100;
    int thirdDigit = num % 10;
    return secondDigit = (secondDigit - thirdDigit) / 10;
}