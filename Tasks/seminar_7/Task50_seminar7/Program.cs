/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввод некорректного значения. Введите положительное число");
        }
    }
    return result;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetPosition(int[,] matrix)
{
   int posRows = GetNumber("Введите номер строки элемента");
   int posCol = GetNumber("Введите номер столбца элемента");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == posRows && j == posCol)
            {            
                Console.WriteLine($"Значение элемента в позиции ({posRows},{posCol}) = {matrix[i,j]}");
                return;
            }
        } 
    }
    Console.WriteLine("Такого числа в массиве нет");
}

int[,] matrix = GetMatrix(3, 4);
GetPosition(matrix);
PrintMatrix(matrix);