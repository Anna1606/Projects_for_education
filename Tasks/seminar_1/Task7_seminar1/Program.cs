/*
Задача №7.
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трёхзначное число: ");
string number = Console.ReadLine() ?? "";
int n = Convert.ToInt32(number);

if ((n<=100) && (n>999))
{
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}

