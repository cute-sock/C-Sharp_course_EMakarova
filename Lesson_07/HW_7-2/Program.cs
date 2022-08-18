// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

// тут 1 И 7, обратная той, которую решали на уроке


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] NewArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

string SetCoordinates(int [,] arr)
{
    int x = arr.GetLength(0);
    int y = arr.GetLength(1);
    int a = x * y;

    {
        for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (arr[i, j] == x * y)
                return $" {a}";
        }
    }
    return "Invalid coordinates";
}
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = NewArray(row, column, 1, 20);
Print(arr_1);
Console.Write("Enter coordinate X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter coordinate Y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine(SetCoordinates(arr_1));