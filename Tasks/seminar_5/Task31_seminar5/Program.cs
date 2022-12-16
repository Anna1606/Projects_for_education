/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.

1. получить размерность массива с консоли
2. получить заполненный массив рандомными числами
3. распечатать массив на консоль
4. найти сумму положительных элементов
5. найти сумму отрицательных элемнтов
6*.попробовать сделать это в одном методе
*/
//получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }

    return array;
}
//распечатать массив на консоль 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

//найти сумму положительных элементов
int GetPositiveSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i]; // тоже самое, что и: summ = summ + array [i]
    }

    return summ;
}

//найти сумму отрицательных элементов
int GetNegativeSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            summ += array[i];
    }

    return summ;
}
// 1й аргумент - сумма положительных, 2й аргумент - сумма отрицательных
(int, int) GetSumms(int[] array) // кортеж - несколько значений, который выводит метод. 
{                                // в круглых скобках перед методом перечисляются переменные, которые нужно вывести
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negativeSumm += array[i];
        else
            positiveSumm += array[i];
    }

    return (positiveSumm, negativeSumm); // возврат переменных обязательно в том же порядке, что и в круглых скобках перед методом
}


int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);
int positiveSumm = GetPositiveSumm(array);
int negativeSumm = GetNegativeSumm(array);

(int posSum, int negSum) = GetSumms(array);

Console.WriteLine($"Сумма отрицательных: {negativeSumm}, сумма положительных: {positiveSumm}");
Console.WriteLine($"Сумма отрицательных: {negSum}, сумма положительных: {posSum}");
