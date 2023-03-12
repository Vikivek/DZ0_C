﻿Console.Clear();
/*
Задача 64: Задайте значение N. 
Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write(PrintNum(n));

string PrintNum(int n, int i = 1)
{
    if (i >= n)
        return i.ToString();
    return $"{PrintNum(n, i + 1)}, {i}";

}
*/
/*
Задача 66: Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int n, m;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out n);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out m);


void PrintSum(int a, int b)
{
    if (a == 0 || b == 0) return 0;
    if (a < b || a > b)
    {
        return (a * PrintSum(a + 1, b));
        Console.Write($"{a} ");
    }
    if (a == b)
    {
        Console.Write($"{a} "); return;
    }
}
PrintSum(n, m);