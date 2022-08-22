// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int row_size = InputNumbers("Input number: ");
int column_size = row_size;
int range = InputNumbers("Input range of array elements: ");

int[,] array = new int[row_size, column_size];
CreateArray(array);
WriteArray(array);

int MinSumRow = 0;
int SumRow = SumRowElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int TempSumRow = SumRowElements(array, i);
  if (SumRow > TempSumRow)
  {
    SumRow = TempSumRow;
    MinSumRow = i;
  }
}

Console.WriteLine($"The row with the smallest sum of elements: {MinSumRow + 1}; Total min sum = {SumRow}");


int SumRowElements(int[,] array, int i)
{
  int SumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    SumRow += array[i,j];
  }
  return SumRow;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}