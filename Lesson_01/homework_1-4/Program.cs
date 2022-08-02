// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());

// operator (%) denotes as a reminder => remainder means the remaining value of a division,
// как будто делишь в столбик и получаешь остаток, если не надо переходитьна десятые, через зяпятую...
if (a%2==0)
{
    // оператор ($) нужен, чтобы в текст можно было вставить число...(?)..
    Console.WriteLine($"Number {a} is even");
}
else
{
Console.WriteLine($"Number {a} is odd");
}
