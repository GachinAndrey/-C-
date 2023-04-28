/* Задача 18ю Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (X и Y).
*/

Console.WriteLine("Введите номер четверти: ");
string input = Console.ReadLine();

string range = Range(input);
Console.WriteLine(range == null ? "Введён некорректный номер четверти" : range);

string Range(string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num == "2") return "x < 0, y > 0";
    if (num == "3") return "x < 0, y < 0";
    if (num == "4") return "x > 0, y < 0";
    return null;
}