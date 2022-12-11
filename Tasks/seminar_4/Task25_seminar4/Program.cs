/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
b = Math.Abs(b);

if (b != 0)
{
    double count = 1;
    double intResult = 1;
    double result = 0;

    while (count <= b)
    {
        intResult = intResult * a;
        result = intResult;
        count++;
    }
Console.WriteLine($"Число {a} в степени {b} = {result}");
}
else
{
    Console.WriteLine("Второе число не может быть равно 0");
}