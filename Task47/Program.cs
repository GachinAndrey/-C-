/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] CreateMatrixFormula(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} "); // 5 - форматирование отступа
        }
        Console.WriteLine("| ");
    }
}



Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixFormula(rows2, columns2);
PrintMatrix(array2d);