/*
Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

1. получения числа (размерность массива)
2. инициализация массива
3. печать массива
4. перевернуть массив
*/

int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[] InitArray(int dimension)
{
    Random rnd = new Random();
    int[] array = new int [dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int [] array)
{
    int [] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i]; // тоже самое по другому: result[array.Length - i - 1] = array[i]
        count++;
    }
    return result;
}
int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);

int[]result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result); // встроенная функция для переворота массива через класс Array
PrintArray(result);