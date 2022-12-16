/*
Задача 37: Найдите произведение пар чисел в одномерном
массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в
новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] array = InitArray(GetNumber("Vvedite chislo: "));
int length;
if(array.Length % 2 == 0)
    length = array.Length / 2;
else
    length = array.Length / 2 + 1;

int[] result = new int[length];
    
for (int i = 0; i < length; i++)
{
    if(i == array.Length - 1 - i)
        result[i] = array[i];
    else
        result[i] = array[i] * array [array.Length - 1 - i];    
}
PrintArray(array);
PrintArray(result);
