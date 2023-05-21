/* Задача 29. Напишите программу, которая задаёт массив 
из 8 элементов, заполненный псевдослучайными числами 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = new int[8];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");


void FillArray(int[] arr)
{
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100); // намеренно задан диапазон до 100, иначе получаются длинные числа
    }
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else Console.Write(arr[i] + " ");
    }
}