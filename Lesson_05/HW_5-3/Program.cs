// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


double[] MassMinMax(int Mas, int x)
{
    double Max, Min, Answer;
    Max = Mas[0];
    Min = Mas[0];
    for (int i = 0; i < x; i++)
    {
        if (Mas[i] > Max)
            Max = Mas[i];
        if (Mas[i] < Min)
            Min = Mas[i];
    }
    Answer = Max - Min;
    Console.WriteLine($"min max value diff {Answer}");
    return 0;
}

int main()
{
    int[] array = new int[10];
    double Max, Min;
    int x;

    do
    {
        Console.WriteLine("enter number of array elements: ");
        x++;
        if (x < 2 && x > 10);
    }
    while (x < 2 && x > 10);
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine($"insert array element {i}");
       Console.WriteLine(Mas[i]);
    }
    
    MassMinMax(Mas, x);
}

double[] arr_1 = MassMinMax(10);
Print(arr_1);
main(arr_1);