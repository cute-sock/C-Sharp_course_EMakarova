﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void Square (int a)
{
    int b = 1;
    while (b <= a)
        {
            Console.WriteLine(Math.Pow(b, 2));
            //Math.Pow(b, 2) - pow - возведение в..., цифра после переменной через (,), это степень, в которую возвести
            b += 1;
            // b = b+1
            }
}
Square(10);