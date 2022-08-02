// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Write("Enter 5-digit number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Number {number} IS palindrome");
  }
  else Console.WriteLine($"Number {number} - IS NOT palindrome");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Error! Enter 5-digit number");

// вариант после разбора ДЗ

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "no";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome(14212);
Palindrome(23432);
Palindrome(12821);
Palindrome(1248421);
Palindrome(12488421);
