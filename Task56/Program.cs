/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixFormula(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] matrix)
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

bool ValueMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else return false;
}

int SumRowsElements(int[,] array, int i)
{
    int sumRows = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRows += array[i, j];
    }
    return sumRows;
}

int MinSumRows(int[,] array2d)
{
    int minSumRows = 0;
    int sumRows = SumRowsElements(array2d, 0);
    for (int i = 1; i < array2d.GetLength(0); i++)
    {
        int tempSumLine = SumRowsElements(array2d, i);
        if (sumRows > tempSumLine)
        {
            sumRows = tempSumLine;
            minSumRows = i;
        }
    }
    return minSumRows;
}
/*
//пользовательский ввод
Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixFormula(rows2, columns2, minimum, maximum);
*/
int[,] array2d = CreateMatrixFormula(4, 4, -10, 10); //убрать при активации ввода пользователем
PrintMatrix(array2d);
Console.WriteLine();

if (ValueMatrix(array2d))
{
    int minSumRows = MinSumRows(array2d);
    Console.WriteLine($"Строкa с наименьшей суммой элементов {minSumRows + 1}");
}
else
{
    Console.WriteLine("Error!");
}