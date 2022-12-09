/* 
Задача №5.
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
*/

Console.WriteLine("Введите число ");
string number = Console.ReadLine() ?? "";
int n = Convert.ToInt32(number);
n = Math.Abs(n);

for (int i = -n; i <= n; i++)
{
    Console.Write(i+" ");
}

