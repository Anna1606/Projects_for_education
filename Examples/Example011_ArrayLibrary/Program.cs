void FillArray(int[] collection) // метод, который заполняет массив случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col) // Метод, который выводит массив на экран
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find) // метод для нахождения позиции элемента в массиве (например, когда нужно найти четвертое число в массиве)
{
   int count = collection.Length;
   int index = 0;
   int position = -1; /*Переменная, в которую будет сохранен индекс искомого значения элемента.
                       По умолчанию принято обозначать её -1, для того, чтобы в случае отсутствия
                       в массиве искомого элемента, было понятно, что такой позиции не существует. */

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив, в котором 10 элементов 
                           //(по умолчанию он будет заполнен нулями)
FillArray(array);
PrintArray(array);
Console.WriteLine(); //пустая строка

int pos = IndexOf(array, 4); // в массиве ищем индекс цифры 4
Console.WriteLine(pos);