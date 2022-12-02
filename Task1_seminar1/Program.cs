/* 
Напишите программу, которая на вход принимает число и выдает его квадрат
(число умноженное само на себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine() ?? "";
int number = Convert.ToInt32(numberStr);

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");