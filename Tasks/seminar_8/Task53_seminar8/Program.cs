/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

int[] line0 = new int[arr.GetLength(1)];
int[] line1 = new int[arr.GetLength(1)];

for (int i = 0; i < line0.Length; i++)
    line0[i] = arr[0, i];

for (int i = 0; i < line0.Length; i++)
    line1[i] = arr[arr.GetLength(0)-1, i];

PrintArray(arr);

for (int i = 0; i < line0.Length; i++)
    arr[0, i] = line1[i];
for (int i = 0; i < line0.Length; i++)
    arr[arr.GetLength(0) - 1, i] = line0[i];

Console.WriteLine();
Console.WriteLine();
PrintArray(arr);
