// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

// начинаем с 1, не получится двигаться с двойкой. Нужно либо игнорировать, либо начать с четного
//надо + num%2 сделать, а потом шагать +2
// не звыбть условия выхода
// потом четность/нечетность, потом вывод

// Correct version

void EvenValuesMN(int min, int max)
{
if (max < min) return;
EvenValuesMN(min, max - 1);
if (max % 2 == 0)
Console.Write($"{max} ");
}
EvenValuesMN(0, 10);



// _____ ver.1 ___________________________________________________________________________

//void EvenValuesMN(int min, int max)
//{
//    if (min < max) return;
//    min = min % 2;
//    min++;
 //   EvenValuesMN(min, max - 1);
 //   Console.Write($"{max} ");

//}
//Console.WriteLine(EvenValuesMN(1, 10));


// _____ ver.2 ___________________________________________________________________________

//int EvenValuesMN(int min, int max)
//{
//    if (min < max) ;
//    return min % 2 == 0;

//    EvenValuesMN(min, max - 1);
//    Console.Write($"{max} ");
//}

//Console.WriteLine(EvenValuesMN(0, 10));
//EvenValuesMN(0, 10);


// _____ ver.3 ___________________________________________________________________________
//void EvenValuesMN(int min, int max)
//{
//    if (min % 2 == 0) return;
//    EvenValuesMN(min, max - 1);
//    Console.Write($"{max} ");
//}
//Console.WriteLine(EvenValuesMN(0, 10));