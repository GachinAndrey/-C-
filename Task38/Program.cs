/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

double[] CreateArrayRndDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return arr;
}

void PrintArray(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MinMaxElement(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return max - min;

}

Console.Write("Введите число элементов: ");
int elements = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndDouble(elements);

Console.Write("[");
PrintArray(arr, " ");
Console.WriteLine("]");

double minMaxElement = MinMaxElement(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {minMaxElement}");