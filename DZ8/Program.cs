Console.Clear();
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
/*
int n, m;
Console.Write($"Введите число n: ");
int.TryParse(Console.ReadLine(), out n);
Console.Write($"Введите число m: ");
int.TryParse(Console.ReadLine(), out m);

Console.Write($"Сумма натуральных элементов в промежутке от n до m равна {Sum(n, m)}");

int Sum(int m, int n)
{
    if (m == n)
        return m;
    else
        return m + Sum(m + 1, n);
}
*/
/*
Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int m, n;
Console.Write($"Введите число m: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите число n: ");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"{Akk(m, n)}");

int Akk(int m, int n)
{
    if (m == 0)
        return n + 1;

    else
    if (n == 0 && m > 0)
        return Akk(m - 1, 1);

    else
        return (Akk(m - 1, Akk(m, n - 1)));
}
