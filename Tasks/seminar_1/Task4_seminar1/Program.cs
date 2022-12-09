/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


Console.WriteLine("Введите первое число: ");
string FirstNumber = Console.ReadLine();
int a = Convert.ToInt32(FirstNumber);
Console.WriteLine("Введите второе число: ");
string SecondNumber = Console.ReadLine();
int b = Convert.ToInt32(SecondNumber);
Console.WriteLine("Введите третье число: ");
string ThirdNumber = Console.ReadLine();
int c = Convert.ToInt32(ThirdNumber);

int MaxNumber = a;

if ((b > a) && (b > c))
{
    MaxNumber = b;
}
else 
{
    if ((c > a) && (c > b))
    {
    MaxNumber = c;
    }
}
Console.Write("Максимальное число: ");
Console.WriteLine(MaxNumber);
