// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// https://blog.fenix.help/podgotovka-k-testam-yekzamenam-zachetam/pravilo-umnozheniya-matrits-primery-s-resheniyem
// https://lfirmal.com/matritsyi-chastnyie-vidyi-matrits/#%D0%A3%D0%BC%D0%BD%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86

// Согласованными матрицами называют матрицы вида A = [m ☓ n] и B = [n ☓ k], где количество столбцов А равно количеству строк В.

int x = InputNumbers("Insert number of columns for Array A = Number of rows  for Array B: ");
int y = InputNumbers("Insert number of rows for Array A: ");
int z = InputNumbers("Insert number of columns for Array B: ");
int range = InputNumbers("Insert number: ");

int[,] ArrayA = new int[x, y];
CreateArray(ArrayA);
Console.WriteLine($"Array A:");
WriteArray(ArrayA);

int[,] ArrayB = new int[y, z];
CreateArray(ArrayB);
Console.WriteLine($"Array B:");
WriteArray(ArrayB);

int[,] ArrayC = new int[x,z];

MultiplyMatrix(ArrayA, ArrayB, ArrayC);
Console.WriteLine($"Multiplication of Array A and Array B:");
WriteArray(ArrayC);

void MultiplyMatrix(int[,] ArrayA, int[,] ArrayB, int[,] ArrayC)
{
  for (int i = 0; i < ArrayC.GetLength(0); i++)
  {
    for (int j = 0; j < ArrayC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < ArrayA.GetLength(1); k++)
      {
        sum += ArrayA[i,k] * ArrayB[k,j];
      }
      ArrayC[i,j] = sum;
    }
  }
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