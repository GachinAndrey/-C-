/*Задача 62. Напишите программу, 
которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] SpiralFillingMatrix(int size)
{
    int[,] matrix = new int[size, size];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size)
    {
        matrix[i, j] = num;
        if (i <= j + 1 && i + j < size - 1) ++j;
        else if (i < j && i + j >= size - 1) ++i;
        else if (i >= j && i + j > size - 1) --j;
        else --i;
        ++num;
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

Console.WriteLine("Введите размер квадратной матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array2d = SpiralFillingMatrix(rows);
PrintMatrix(array2d);