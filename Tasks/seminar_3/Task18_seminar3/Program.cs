/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (х и у).
*/

string MyMethod (int quarter)
{
    switch (quarter)
    {
        case 1:
            return "x = 0 ... +∞\ny = 0 ... +∞";
            break;
        case 2:
            return "x = 0 ... -∞\ny = 0 ... +∞";
            break;
        case 3:
            return "x = 0 ... -∞\ny = 0 ... -∞";
            break;
        case 4:
            return "x = 0 ... +∞\ny = 0 ... -∞";
            break;        
        default:
            return "Нужно ввести число от 1 до 4 (четверть)";
    }
}
Console.WriteLine(MyMethod(1));
Console.WriteLine("");
Console.WriteLine(MyMethod(2));
Console.WriteLine("");
Console.WriteLine(MyMethod(3));
Console.WriteLine("");
Console.WriteLine(MyMethod(4));
Console.WriteLine("");
Console.WriteLine(MyMethod(6));
Console.WriteLine("");