/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
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

void PrintMatrix (int[,] matrix)
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

double[] FindColumnSumm(int[,] matrix)
{
    int height = matrix.GetLength(0);
    int length = matrix.GetLength(1);
    double[] result = new double[length];

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            result[j] += matrix[i, j];
        }
    }
    return result;
}

void PrintResult(double[] array, int[,] matrix)
{
    int length = matrix.GetLength(0);

    for (int i = 0; i < length; i++)
    {
        Console.Write("{0:0.0} ",array[i] / length);
    }
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
double[] result = FindColumnSumm(matrix);
PrintResult(result, matrix);