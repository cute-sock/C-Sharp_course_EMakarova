// ДЗ 3. Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции.

void RandomArray(int num)
// еще можно void RandomArray(int num),...
{   
    int[] array = new int[num];
    // тогда здесь вместо int[8] ставится int[num]
    
    for (int i = 0; i < num; i++)
    // тут 8 заменяем на num...
    {
        array[i] = new Random().Next(1000);
        Console.Write($"{array[i]} ");
    }    
}

RandomArray(8);
// и тогда тут в скобки можно записать любой размер массива.