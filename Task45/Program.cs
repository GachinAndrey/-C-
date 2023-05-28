/*Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/
int[] oldArray = CreateArrayRNDInt(5, 10, 20);
PrintArray(oldArray);
Console.WriteLine();
int[] newArray = CopyArray(oldArray);
//newArray[0] = 1000; //проверка на копию
PrintArray(newArray);

int[] CreateArrayRNDInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}

int[] CopyArray(int[] arr)
{
    int[] newarray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newarray[i] = arr[i];
    }

    return newarray;
}
