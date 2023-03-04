Console.Clear();

/*Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Кол-во элементов > {count}");

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5) 
*/
/*
double b1, k1, b2, k2;

Console.WriteLine("Введите значение b1");
Double.TryParse(Console.ReadLine()!, out b1);
Console.WriteLine("Введите число k1");
Double.TryParse(Console.ReadLine()!, out k1);
Console.WriteLine("Введите значение b2");
Double.TryParse(Console.ReadLine()!, out b2);
Console.WriteLine("Введите число k2");
Double.TryParse(Console.ReadLine()!, out k2);

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Две прямые пересекутся в координатах ({x};{y})");
}
else
{
    Console.WriteLine($"Две прямые параллельны друг другу");
}
*/