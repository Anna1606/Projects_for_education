/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
     Console.Write($"{i * i * i} ");
    }
}
else
{
    Console.WriteLine("Число должно быть положительным");
}