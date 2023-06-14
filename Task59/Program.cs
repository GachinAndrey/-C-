/*Задача 59: Задайте двумерный массив из 
целых чисел. Напишите программу, которая
удалит строку и столбец, на пересечении которых 
расположен наименьший элемент массива.

например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
наименьший элемент 1, на выходе получим:
9 2 3
4 2 4
2 6 7

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

int[] FindMinElement(int[,] matrix)
{
    int minElement = matrix[0, 0];
    int position1 = 0;
    int position2 = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                position1 = i;
                position2 = j;
            }
        }
    }
    return new int[] { position1, position2, minElement };
}

int[,] CreateNewMatrix(int[,] matrix, int row, int column)
{
    int size1 = matrix.GetLength(0) - 1;
    int size2 = matrix.GetLength(1) - 1;
    int[,] newMatrix = new int[size1, size2];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == row) m += 1;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == column) n += 1;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        n = 0;// нужно обнулить после каждого прохода по строке
        m++;
    }
    return newMatrix;
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
int[] pos = FindMinElement(array2d);
int minElement = pos[2];
int[,] newMatrix = CreateNewMatrix(array2d, pos[0], pos[1]);
Console.WriteLine(minElement);
Console.WriteLine();
PrintMatrix(newMatrix);