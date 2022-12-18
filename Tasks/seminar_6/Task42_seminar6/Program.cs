/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

string GetBinaryFromDecimal(int decimalNumber)
{
    // 11 % 2 = 5.5 = 1
    // 5 % 2 = 2.5 = 1
    // 2 % 2 = 1 = 0
    // 1 % 2 = 0.5 = 1
    int number = decimalNumber;
    int ostatok = 0;
    string result = String.Empty;

    while (number >= 1)
    {
        ostatok = number % 2;
        number /= 2;
        if (ostatok != 0)
        {
            result += "1";
        }
        else
        {
            result += "0";
        }
    }

    return new string (result.Reverse().ToArray());
}

Console.WriteLine(GetBinaryFromDecimal(11));
Console.WriteLine(GetBinaryFromDecimal(158));
