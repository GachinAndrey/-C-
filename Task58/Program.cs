/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

bool ValueMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0) || matrix1.GetLength(0) == matrix2.GetLength(1)) return true;
    else return false;
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.WriteLine("Введите число строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = CreateMatrixFormula(rows1, columns1, -5, 5);

Console.WriteLine("Введите число строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] secomdMartrix = CreateMatrixFormula(rows2, columns2, -5, 5);

Console.WriteLine("Первая матрица:");
PrintMatrix(firstMartrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintMatrix(secomdMartrix);
Console.WriteLine();

if (ValueMatrix(firstMartrix, secomdMartrix))
{
    int[,] resultMatrix = new int[rows1, columns2];
    MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
    Console.WriteLine($"Произведение первой и второй матриц:");
    PrintMatrix(resultMatrix);
}
else
{
    Console.WriteLine($"Error! Матрицы нельзя умножить!");
}
/* Я не понял умножение матриц и сделал условие для умножения 
количество строк 1й матрицы = количеству столбцов 2й матрицы или
количество строк 2й матрицы = количеству столбцов 1й матрицы.
Также можно прикрутить диапазон чисел в матрице,
в данном варианте не стал этого делать.
*/