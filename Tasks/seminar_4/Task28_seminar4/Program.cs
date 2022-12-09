/*
Задача 28: Напишите программу, которая принимает на
вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
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

long GetResult (int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = i * result;
    }
    return result;
}

int number = GetNumber("Введите число: ");
long fakt = GetResult(number);
Console.WriteLine($"Факториал числа {number} равен {fakt}");