
// ДЗ-2 - методичка для решения https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/
// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 *x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)

// Convert.ToDouble
//ToDouble(String) - Преобразует заданное строковое представление числа в эквивалентное число с плавающей запятой двойной точности.
//ToDouble(Object, IFormatProvider) - Преобразует значение заданного объекта в число с плавающей запятой двойной точности,
// используя указанные сведения об особенностях форматирования, связанных с языком и региональными параметрами.

Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 1);
y = Math.Round(y, 1);
 
Console.WriteLine($"intersection coordinates: (x = {x}; y = {y})");
