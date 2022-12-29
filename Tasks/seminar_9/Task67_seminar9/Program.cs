/*
Задача 67: Напишите программу, которая будет принимать на 
вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;

int SumRec(int num, int sum)
{
    if (num == 0) return sum;
    else {
        sum += num % 10;
        return SumRec(num / 10, sum);
    } 
}

Console.WriteLine(SumRec(n, sum));
