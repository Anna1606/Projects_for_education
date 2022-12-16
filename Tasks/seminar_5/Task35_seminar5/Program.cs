/*
Задача 35: Задайте одномерный массив из 123 случайных 
чисел. Найдите количество элементов массива, значения
которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов.
В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int Count(int[] array, int min, int max)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= min) && (array[i] <= max))
            result++;
    }
    return result;
}

//int[] a = InitArray(23);
int[] a = {10, 11, 12, 13, 14};
Console.WriteLine(String.Join(" ", a));
Console.WriteLine(Count(a, 10, 99));

