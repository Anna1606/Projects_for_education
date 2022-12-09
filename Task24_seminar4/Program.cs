//метод, который получает число с консоли
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

//метод, который считает сумму от 1 до n
int GetSumm(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}

int number = GetNumber("Введите число больше 0:");
int summ = GetSumm(number);

Console.WriteLine($"сумма чисел от 1 до {number} = {summ}");

