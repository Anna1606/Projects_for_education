/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

// Получить массив, заполненный рандомными числами
int[] array = new int[10];

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-20, 20);
    }
}

// Распечать массив
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}
// найти сумму элементов, стоящих на нечетных позициях
int FindSumm (int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(i % 2 != 0) summ = summ + numbers[i];
    }
    return summ;
}

FillArray(array);
PrintArray(array);
int summ = FindSumm(array);

Console.Write($"-> сумма элементов, стоящих на нечетных позициях равна {summ}");