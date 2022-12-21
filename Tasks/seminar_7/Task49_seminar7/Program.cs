/*
Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы на
их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int[,] arr = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};


var dim0 = arr.GetLength(0);
var dim1 = arr.GetLength(1);

for (int i = 0; i < dim0; i++)
    for (int j = 0; j < dim1; j++)
        if (((i+1) % 2) == 0 && ((j+1) % 2) == 0)
            arr[i,j] *= arr[i, j];


Console.WriteLine("Распечатка массива: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write(String.Format("{0,4:0.#}", arr[i, j]));
    Console.WriteLine();
}

