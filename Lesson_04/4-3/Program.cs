﻿// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void RandomArray()
// еще можно void RandomArray(int num),...
{   
    int[] array = new int[8];
    // тогда здесь вместо int[8] ставится int[num]
    
    for (int i = 0; i < 8; i++)
    // тут 8 заменяем на num...
    {
        array[i] = new Random().Next(2);
        Console.Write($"{array[i]} ");
    }    
}

RandomArray();
// и тогда тут в скобки можно записать любой размер массива.