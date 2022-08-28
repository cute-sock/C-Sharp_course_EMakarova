// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Enter number: ");
 int a = int.Parse(Console.ReadLine());

int sum = 0;
while (a > 0)
{
    sum += a % 10;
   a /= 10;
}
Console.WriteLine(sum);


int SumNum(int sum)
{
   if (sum == 0) return 0;
    return SumNum(sum / 10) + sum % 10;
}

 //version 2 (Maria's version)

 //int SumNum(int sum)
//{
//   if (sum == 0) return 0;
 //  return SumNum(sum / 10) + sum % 10;
//}

//Console.WriteLine(SumNum(453));
//Console.WriteLine(SumNum(45));
