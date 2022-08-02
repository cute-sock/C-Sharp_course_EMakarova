// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
int MaxDigit(int Number)

{

    if (Number / 10 > Number % 10)

        return Number / 10;

    else

        return Number % 10;

}

int a = new Random().Next(10, 100);

Console.WriteLine(a);

Console.WriteLine(MaxDigit(a));



// 2 вариант

int MaxNumber(int a)
{
    Console.WriteLine(a);
    
    if (a % 10 > a / 10)
    {
        return a % 10;
    }
    else
    {
        return a / 10;
    }
}
