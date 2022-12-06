/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.

А(3,6); В(2,1) -> 5,09
А(7,5); В(1,1) -> 7,21
*/

Console.WriteLine("Введите координаты X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double DistXY (int x1, int y1, int x2, int y2)
{
    double result =0;
    result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
    return result;
}

Console.WriteLine($"Расстояние между точками = {DistXY(x1,y1,x2,y2)}");