/* Задача 32: Напишите программу замена элементов 
массива: положительные элементы замените на 
соответствующие отрицательные и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
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

InverseArray(array);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");