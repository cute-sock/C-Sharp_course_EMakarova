﻿// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void Print(int[,] arr)
{
    double row_size = arr.GetLength(0);
    double column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j], 4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column, 20, -10);
Print(arr_1);