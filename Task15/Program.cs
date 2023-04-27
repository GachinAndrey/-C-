/*Задача 15: Напишите программу,
которая принимает на вход цифру,
обозначающую день недели и проверяет,
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// Console.WriteLine("День цифру дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day >= 1 && day < 6)
// {
//     Console.WriteLine($"{day} -> нет");
// }
// else if (day == 6 || day == 7)
// {
//     Console.WriteLine($"{day} -> да");
// }
// else
// {
//     
// }

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    bool result = WeekendDay(day);
    Console.WriteLine(result ? $"{day} -> нет" : $"{day} -> да");
}
else
{
    Console.WriteLine("Не корректно введён день!");
}

bool WeekendDay(int num)
{
    return day >= 1 && day < 6;
}