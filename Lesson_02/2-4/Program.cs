// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void Checking (int N)

{

if (N % 7 == 0 && N % 23 == 0)

Console.WriteLine ("YES");

else

{

Console.WriteLine ("NO");

}

}

Console.WriteLine("write a number N: ");

int n = int.Parse(Console.ReadLine());

Checking(n);
