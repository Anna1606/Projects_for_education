/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число: ");
string Number = Console.ReadLine() ?? "";
double a = Convert.ToInt32(Number);

if (a % 2==0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}