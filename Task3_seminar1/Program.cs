/*
Задача №3.
Напишите программу, которая будет выдавать название дня недели
по заданному номеру

3 -> среда
5 -> пятница
*/

Console.WriteLine("Введите число: ");
string day = Console.ReadLine() ?? "";

switch (day) // выбери день 
{
    case"1": Console.WriteLine("Понедельник"); // если 1, то это Понедельник
    break;                                     // если нет, то заверши этот блок и перейди к следующему.

    case"2": Console.WriteLine("Вторник");
    break;

    case"3": Console.WriteLine("Среда");
    break;

    case"4": Console.WriteLine("Четверг");
    break;

    case"5": Console.WriteLine("Пятница");
    break;

    case"6": Console.WriteLine("Суббота");
    break;

    case"7": Console.WriteLine("Воскресенье");
    break;

    default: Console.WriteLine("Вы ввели неверное число"); // если ничего из перечисленного не подходит, то ...
    break;                                                 // заверши программу
}
