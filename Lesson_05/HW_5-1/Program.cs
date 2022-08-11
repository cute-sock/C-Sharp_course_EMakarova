// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[5];
int x = 0, sum = 0;
Random rnd = new Random();

Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    arr[i] = rnd.Next(100, 999);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();

foreach (int element in arr)
{
    Console.Write("{0} ", element);
    if (element % 2 == 0)
    {
        x++;
        sum += element;
    }
}

Console.WriteLine("even numbers -> {0} ", x, sum);


