/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int Ackerman( int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Ackerman(m, n - 1);
        m--;
    }
    return n + 1;
}
int m = GetNumber("Введите число: ");
int n = GetNumber("Введите число: ");
Console.WriteLine($"Функция Аккермана, где n = {n}, m = {m} равна: " + Ackerman(n, m));