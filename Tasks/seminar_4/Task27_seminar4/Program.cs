/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}

int GetSum(int number)
{
    int intNumber = number;
    int sum = number % 10;

    while (intNumber > 0)
    {
        intNumber = (intNumber - (intNumber % 10)) / 10;
        sum = sum + (intNumber % 10);
    }

    return sum;
}

int number = GetNumber("Введите число: ");
int sum = GetSum(number);

Console.WriteLine($"Сумма цифр в числе {number} = {sum}");