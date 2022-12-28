/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] GetMatrix()
{
    int n = 4;
    int[,] matrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= n * n)
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4:0.#}", matrix[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);