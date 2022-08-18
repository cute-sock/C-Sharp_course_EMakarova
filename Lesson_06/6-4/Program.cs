// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования дробных чисел.
// Задать массив дробных чисел. массив можно буквы и числа
// создаем массив, передали своей новой функции и она сложила ее в другой массив

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] InitialArray(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (5 + 40) - 10, 3);
        //string[] DaysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
    }
    return arr;
}

double[] CopiedArray(double[] arr)
{
    int size = arr.Length;
    double[] new_arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        new_arr[i] = arr[i];
    }
    return new_arr;
}

double[] arr_1 = InitialArray(5, 1, 11);
Print(arr_1);
double[] arr_1_new = CopiedArray(arr_1);
Print(arr_1_new);