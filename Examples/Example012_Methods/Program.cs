// Вид 1 - методы, которые ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); // вызов данного метода


// Вид 2 - методы, которые ничего не возвращают, но могут принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); // вызов  метода, аргументы могут быть именованными (например, если их несколько)

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // увеличение счетчика на 1 называют инкрементом
                 // уменьшение счетчика на 1 называют декрементом
    }
}
Method21(msg: "Текст",count: 4); // если переменные именованы, то в методе их вызвать в любом порядке.
// зацикливание программы можно убрать комбинацией клавиш: ctrl + C


// Вид 3 - методы, которые что-то возвращают, но ничего не принимают
int Method3() // Для этого вида методов обязательно нужно указывать тип данных, который нужно вернуть
{
  return DateTime.Now.Year;  // обязательно в этом типе методов использовать оператор return
}
int year = Method3(); // через идентификатор переменной положить туда значение, присваемое методом
Console.WriteLine(year);


//Вид 4 - методы, которые что-то принимают, и что-то возвращают
string Method4(int count, string text )
{
    string result = String.Empty; // изначально результат будет пустой строкой
    //string result = " ";        // означет тоже самое, что и выражение выше

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

// Использование цикла в цикле (пример: вывод таблицы умножения)

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j<= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}"); // $ означает интерполяцию строк, позволяет использовать переменные в фигурных скобках
    }
    Console.WriteLine();
}

/* Работа с текстом
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с"

Ясна ли задача?
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Выдадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();


// Метод сортировки / метод min/max

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);