/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1,5);
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

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    result[i,j] += matrixA[i,k] * matrixB[k,j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Умножать матрицы можно только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы.");
    }    
    return result;
}

int[,] matrixA = GetMatrix(2,2);
int[,] matrixB = GetMatrix(2,2);
PrintMatrix(matrixA);
PrintMatrix(matrixB);
int[,] matrixC = MultiplyMatrix(matrixA,matrixB);
PrintMatrix(matrixC);