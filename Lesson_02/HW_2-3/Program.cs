// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//void ThirdDigit(int num);
//Console.WriteLine("Enter number: ");
//{
//int num = int.Parse(Console.ReadLine());
//if (num <=99)
//{
//    Console.WriteLine("error! No third digit");
//        return;
//}
///while (num >= 999)
//Console.WriteLine(num % 10);
//}
//    
//ThirdDigit(int.Parse(Console.ReadLine()));


void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("there is no third digit");
        return;
    }

    while (num > 999) num = num / 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()));
