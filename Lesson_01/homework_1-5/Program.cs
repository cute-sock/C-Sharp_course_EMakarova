// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number: ");
int n = int.Parse(Console.ReadLine());
int index = 2;

while (index <= n)
{
    Console.WriteLine($"{index} ");
    index = index + 2;
}
