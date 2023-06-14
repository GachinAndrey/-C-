/*Задача 53: Задайте двумерный массив.
Напишите программу, которая поменяет местами первую 
и последнюю строку массива.
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

void SwapPosition(int[,] matrix)
{
    int lastPosition = matrix.GetLength(0) - 1;
    int firstPosition = 0;
    int temp = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[firstPosition, j];
        matrix[firstPosition, j] = matrix[lastPosition, j];
        matrix[lastPosition, j] = temp;
    }
}

Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixFormula(rows2, columns2, minimum, maximum); //лучше пользовательский ввод
PrintMatrix(array2d);
Console.WriteLine();
SwapPosition(array2d);
PrintMatrix(array2d);