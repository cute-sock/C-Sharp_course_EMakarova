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

void MassMinMax(double[] Mas)
{
double Max, Min, Answer;
Max = Mas[0];
Min = Mas[0];
for (int i = 0; i < Mas.Length; i++)
{
if (Mas[i] > Max)
Max = Mas[i];
if (Mas[i] < Min)
Min = Mas[i];
}
Answer = Max - Min;
Console.WriteLine($"min max value diff {Answer}");

}

double[] main()
{

Console.WriteLine("enter number of array elements: ");
int x = int.Parse(Console.ReadLine());;
double[] array = new double[x];

for (int i = 0; i < x; i++)
{
    Console.WriteLine($"insert array element {i}");
    array[i] = double.Parse(Console.ReadLine());
}

return array;
}

double[] arr_1 = main();
Print(arr_1);
MassMinMax(arr_1);