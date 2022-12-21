/*
Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной
диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Vveli nevernye danniye. Vvedite korrektnoe chislo");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

//сумма главной диагонали
int GetSumm(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            count+=matrix[i, i];
    }
    return count;
}

//распечатать массив на консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int rows = GetNumber("Введите кол-во строк: ");
int columns = GetNumber("Введите кол-во столбцов: ");
if(rows == columns)
{
    int[,] matrix = InitMatrix(rows, columns);
    PrintMatrix(matrix);
    int diagonalSumm = GetSumm(matrix);
    Console.WriteLine($"Сумма элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д. = {diagonalSumm}");
}
else
    Console.WriteLine("Матрица не квадратная");
