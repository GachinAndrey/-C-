/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int SumElemOddPozition(int[] arr)
{
    int sum = 0;
    int i = 0;  // 0 - четный индекс массива (нечетная позиция), 
                // 1 - нечетный индекс массива (четная позиция).
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    return sum;
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

int sumElemOddPozition = SumElemOddPozition(array);
Console.WriteLine($"Сумма элементов нечетных позиций {sumElemOddPozition}");