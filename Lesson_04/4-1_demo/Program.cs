// Задача 1(DEMO): Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

                    // делала параллельно с Марией (не работает)
                    // Ошибка сборки. (12,12): error CS0103: Имя "i" не существует в текущем контексте. Строчка "all_sum += i"

//int SunNum(int num)
//{
//    int all_sum = 0;
//    for (int i = 1; i <= num; i++) ;
//    all_sum += i;
                     // for  - в ней находится 3 составляющей, можно работать с несколькими переменными
    // i++ - это i = i + 1

//    return all_sum;
//}

//Console.WriteLine(SunNum(7));




// копипаст Марии (работает)
int SumNUm(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;

    return all_sum;
}

Console.WriteLine(SumNUm(7));