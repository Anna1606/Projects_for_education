/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

//Получить размерность массива
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

// Получить М чисел с консоли
int[] GetFewNumbers(int number)
{
    number = Math.Abs(number);
    int[] result = new int[number];
    int i = 0;
    int newNumber = 0;

    while (number > i)
    {
        newNumber = GetNumber("Введите число");
        result[i] = newNumber;
        i++;
    }
    return result;
}
// распечатать массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}
// найти количество положительных чисел в массиве
int GetPositiveSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) summ ++;
    }

    return summ;
}

int firstNumber = GetNumber("Введите количество чисел, которое хотите завести");
int[] array = GetFewNumbers(firstNumber);
PrintArray(array);
int posSum = GetPositiveSumm(array);
Console.WriteLine($"{posSum} чисел больше 0");
