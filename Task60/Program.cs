/*Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы 
каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] CreateArray3d(int translation, int rows, int columns)
{
    int[,,] newArray = new int[translation, rows, columns];
    int count = 10;
    for (int k = 0; k < translation; k++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
            {

                newArray[k, i, j] = count;
                count++;
            }
        }
    }
    return newArray;
}

void PrintArray3d(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("[" + k + "," + i + "," + j + "]" + array[k, i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество смещений: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,,] array = CreateArray3d(z, x, y);
PrintArray3d(array);

//работает только для квадратной матрицы