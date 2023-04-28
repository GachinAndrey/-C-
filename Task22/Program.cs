/* Задача 22. Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
*/

Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Square(numberN);

void Square(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} {count * count,5}");
        count++;
    }
}