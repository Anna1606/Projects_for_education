/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// получить размерность массива с консоли
int GetNumber(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели неккоректное число");
        }
    }
    return result;
}

// Получить массив, заполненный рандомными числами

double[] FillArray(int dimension)
{
    double[] array = new double[dimension];
    for (int i = 0; i < dimension; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
    return array;
}

// Распечать массив
void PrintArray(double[] numbers)
{
    
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}

// найти максимальный и минимальный элементы массива

 (double, double, double) FindMaxMin(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    

    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max) max = numbers[i];
        if(numbers[i] < min) min = numbers[i];
    }

    double result = max - min;

    return (max, min, result);
}

int dimension = GetNumber("Введите размерность массива");
double[] array = FillArray(dimension);
PrintArray(array);
(double max, double min, double result) = FindMaxMin(array);
Console.WriteLine($"Разница между {max} и {min} = {result}");