// ДЗ 1. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Deg(int a, int b)
{
    int n_deg = a;

    for (int i = 2; i <= b; i = i + 1)
    {
        n_deg *= a;
        // n_deg = (Math.Pow(a, b)); - не работает...
    }
    return n_deg;
}

Console.WriteLine("Insert 1st digit: ");
int num_a = int.Parse(Console.ReadLine());
Console.WriteLine("Insert 2nd digit: ");
int num_b = int.Parse(Console.ReadLine());

Console.WriteLine(Deg(num_a, num_b));