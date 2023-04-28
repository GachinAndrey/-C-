/*Задача 23 Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Cube(numberN);

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} | {count * count * count}");
        count++;
    }
}