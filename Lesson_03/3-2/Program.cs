// Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//AB = √(xb - xa)2 + (yb - ya)2


double Distance (double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2)),4);
}

Console.WriteLine (Distance(3, 6, 2, 1));
