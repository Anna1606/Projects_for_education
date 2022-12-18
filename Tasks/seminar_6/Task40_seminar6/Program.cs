/*
Задача 40
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

bool doCalculation(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}


int a = 3;
int b = 3;
int c = 3;

Console.WriteLine($"Стороны: {a}, {b}, {c}");
if (doCalculation(a, b, c))
    Console.WriteLine("Треугольник может существовать");
else
    Console.WriteLine("Треугольник не может существовать");

// вариант решения 2:
// string ne = doCalculation(a, b, c) ? "" : " не";
// Console.WriteLine($"Треугольник{ne} может существовать");

// вариант решения 3:
// Console.WriteLine($"Стороны: {a}, {b}, {c}");
// Console.WriteLine("Треугольник "+(doCalculation(a, b, c) ? "" : " не")+" может существовать");