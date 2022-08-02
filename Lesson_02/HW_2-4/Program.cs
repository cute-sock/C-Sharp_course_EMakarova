// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да; 7 -> да;; 1 -> нет

//Console.WriteLine("enter day of week number: ");
//int num = int.Parse(Console.ReadLine());
//string text;
//{  
//    if (num == 6 || num == 7) text = "weekend";
//   Console.WriteLine($"{num} -> {text}");
//
//  if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5) text = "workday";
//   Console.WriteLine($"{num} -> {text}");
//
//}
//Console.WriteLine($"Day of week: {num} -> {text}");


void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "yes";
    Console.WriteLine($"{num} -> {text}");
}

Weekend(6);
Weekend(7);
Weekend(1);
