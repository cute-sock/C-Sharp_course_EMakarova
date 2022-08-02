﻿// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// (x1-x2)*(x1-x2)+(y1-y2)*(x1-x2)+(z1-z2)*(z1-z2)

double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1-z2,2)),2);
}

Console.WriteLine (Distance(7, -5, 0, 1, -1, 9));