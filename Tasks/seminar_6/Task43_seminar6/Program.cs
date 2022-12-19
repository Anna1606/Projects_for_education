/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


// Получить значения от пользователя
double GetNumber(string message)
{
    double result;
    while(true)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

(double, double) GetIntersection (double b1, double k1, double b2, double k2)
{
    double xIntersektion = (b2 - b1) / (k1 - k2);
    double yIntersection = k1 * xIntersektion + b1;

    return (xIntersektion, yIntersection);
}

double b1 = GetNumber("Введите первую координату первой прямой");
double k1 = GetNumber("Введите вторую координату первой прямой");
double b2 = GetNumber("Введите первую координату первой прямой");
double k2 = GetNumber("Введите вторую координату первой прямой");

(double xIntersektion, double yIntersection) = GetIntersection(b1, k1, b2, k2);
Console.WriteLine($"Координаты точки пересечения ({xIntersektion}, {yIntersection})");