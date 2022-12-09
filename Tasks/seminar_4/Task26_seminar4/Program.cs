/*
Задача 26: Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountOfDigits(int x)
{
    int cnt = 0;
    while (x > 0)
    {
        cnt += 1;
        x /= 10;
    }
    return cnt;
}

Console.WriteLine(CountOfDigits(number));