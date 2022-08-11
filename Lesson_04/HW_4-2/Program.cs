// ДЗ 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum_2_digits(int num)
{
    int summa = 0;

    for (int i = num; num != 0; num /= 10)
        
        summa += num % 10;
        // sum += num % 10;

    return summa;
}

Console.WriteLine(sum_2_digits(333));


// NB: почему-то при сложении выдает на единицу меньше суммы...