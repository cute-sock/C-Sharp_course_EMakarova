// Задача 3: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9
// использовать конструкцию foreach

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],2} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[] FrequencyDict(int[,] arr)
{
    int[] freq = new int[8];

    foreach (int item in arr) freq[item] += 1;
    return freq;
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} occurs {arr[i]} times");
    Console.WriteLine();
}

Console.Write("Insert number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Insert number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 8);
Print(arr_1);

int[] mass = FrequencyDict(arr_1);
PrintMass(mass);