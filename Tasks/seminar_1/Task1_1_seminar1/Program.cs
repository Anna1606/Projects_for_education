/* Задача №1
Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.

а = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет
*/

Console.WriteLine("Введите первое число: ");
string FirstNumber = Console.ReadLine() ?? "";
int a = Convert.ToInt32(FirstNumber);
Console.WriteLine("Введите второе число: ");
string SecondNumber = Console.ReadLine() ?? "";
int b = Convert.ToInt32(SecondNumber);

if ((b * b) == a)
{
    Console.WriteLine($"{a} является квадратом {b}");
}
else
{
   Console.WriteLine($"{a} не является квадратом {b}");
}