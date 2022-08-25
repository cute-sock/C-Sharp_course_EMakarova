//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

// https://youtu.be/rh1mP02NFoM?t=229
// https://skillbox.ru/media/code/rekursiya-vokrug-nas/
//https://docs.microsoft.com/ru-ru/archive/msdn-magazine/2012/december/csharp-matrix-decomposition


int SumMN(int m, int n, int sum)
{

    while (m <= n)
    {
        sum += m;
        m++;
        
    }
    return sum;
}

Console.WriteLine(SumMN(1, 10, 0));