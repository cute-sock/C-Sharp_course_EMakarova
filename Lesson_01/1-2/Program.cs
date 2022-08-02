// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

if (b * b == a)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
