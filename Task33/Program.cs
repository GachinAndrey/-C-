/* Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в масииве.

4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

bool NumberInArray(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

Console.Write("Введите число элементов: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[elements];

Console.WriteLine("Введите минимальное число диапазона: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int maximum = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(elements, minimum, maximum);

Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

Console.WriteLine("Введите число, которое нужно проверить в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isExistNum = NumberInArray(number, array);
Console.WriteLine(isExistNum ? "Да" : "Нет");