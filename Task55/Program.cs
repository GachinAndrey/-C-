/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна 
вывести сообщение для пользователя.
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

void ChangePosition(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)//проход по верхнемутреугольнику матрицы
    {
        for (int j = i + 1; j < matrix.GetLength(0); j++)//исключая главную диагональ
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
/*
Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());
*/
//int[,] array2d = CreateMatrixFormula(rows2, columns2, minimum, maximum); //лучше пользовательский ввод
int[,] array2d = CreateMatrixFormula(4, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();

if (ValueMatrix(array2d))
{
    ChangePosition(array2d);
    PrintMatrix(array2d);
}
else
{
    Console.WriteLine("Error!");
}