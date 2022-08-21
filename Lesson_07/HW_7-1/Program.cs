// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write($" {arr[i, j], 6} "); - это как сделать ровненько


Console.Write("Enter number of rows (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

NewArray(arr);

WriteArray(arr);

Console.WriteLine();

void NewArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().NextDouble() * 100 - 50;
        }
    }
}

void WriteArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(arr[i, j], 1);
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

