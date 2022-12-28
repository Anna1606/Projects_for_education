/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов:");
int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
PrintArray(DeleteRowColoumn(matrix));



int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
void FillArrayRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int[,] DeleteRowColoumn(int[,] matrix)
{
    int min = matrix[0, 0];
    int row = 0;
    int newColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i,j];
                row = i;
                newColumn = j;
            } 
        }
    }
int[,] newArr = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
    int newRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == row)
            continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == newColumn)
                continue;
            newArr[newRow, newColumn] = matrix[i, j];
            newColumn++;
        }
        newColumn = 0;
        newRow++;
    }
    return newArr;
}
