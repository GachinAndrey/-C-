/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[,] CreateMatrixFormula(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} "); // 5 - форматирование отступа
        }
        Console.WriteLine();
    }
}
/*
double[,] ArithmeticMeanInColumn(double[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arr[j] = Math.Round(sum / matrix.GetLength(0), 1);
        //Console.Write($"{Math.Round(sum / matrix.GetLength(0), 1)} ");
    }
    //return matrix;
    PrintArrayRes(arr);
}
*/

void PrintArrayRes(double[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}



Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixFormula(rows2, columns2, minimum, maximum);
PrintMatrix(array2d);
Console.WriteLine("Среднее арифметическое в столбце:");
//ArithmeticMeanInColumn(array2d);
double[] arr = new double[array2d.GetLength(1)];
for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum += array2d[i, j];
    }
    arr[j] = Math.Round(sum / array2d.GetLength(0), 1);
}
PrintArrayRes(arr);