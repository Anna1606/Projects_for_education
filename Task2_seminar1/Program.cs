/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число: ");
string FirstNumber = Console.ReadLine();
int a = Convert.ToInt32(FirstNumber);
Console.WriteLine("Введите второе число: ");
string SecondNumber = Console.ReadLine();
int b = Convert.ToInt32(SecondNumber);

if (a > b)
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(b);
}