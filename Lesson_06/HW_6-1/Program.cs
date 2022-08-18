// ДЗ-1. Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// работает пока не пустая строка или крутимся в бесконечном цикле


Console.Write("Enter numbers using backspace: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// ConvertAll - Преобразует массив одного типа в массив другого типа.
// Метод ConvertAll передает каждый элемент входного массива и помещает преобразованные элементы в новый массив.
// Split(Char[]) - Разбивает строку на подстроки на основе указанных символов-разделителей.

int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Number of elements above zero: {count}");