/*
Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int GetRandomNumber()
{
    return new Random().Next(100, 1000); // 100 ... 999
}

void ShowRandomNumber(int number)
{
    Console.WriteLine($"Случайное трехзначное число: {number}");
    string str = number.ToString();
    Console.WriteLine($"> {str[0]}{str[2]}");
}

ShowRandomNumber(GetRandomNumber());