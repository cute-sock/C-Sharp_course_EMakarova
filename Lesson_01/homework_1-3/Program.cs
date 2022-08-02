// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number: ");
int c = int.Parse(Console.ReadLine());

if (a < b)
{
    a = b;
}
if (a < c)
{
a = c;
}

Console.WriteLine($"The largest number is {a}");
