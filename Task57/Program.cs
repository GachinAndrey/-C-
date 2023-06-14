/*Задача 58: Составить частотный словарь 
элементов двумерного массива. Частотный словарь 
содержит информацию о том, сколько раз встречается 
элемент входных данных.
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

int[] MatrixInArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int x = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[x] = matrix[i, j];
            x++;

        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

void DictionaryCounter(int[] arr)
{
    int number = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            Console.WriteLine($"Число {number} встречается {count} раз.");
            number = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {number} встречается {count} раз.");
}

Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixFormula(rows2, columns2, minimum, maximum);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixInArray(array2d);
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
DictionaryCounter(array);
