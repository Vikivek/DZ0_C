﻿/* Задача 10:
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int N;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

Console.Write($"{N} -> {N / 10 % 10}");
*/
/* Задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int N;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
if (N > 99)
{
    while (N > 999)
    {
        N /= 10;
    }
    Console.WriteLine($"{N} -> {N % 10}");

}
else
{
    Console.Write("Нет третьей цифры");
}
*/

/*Задача 15:
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int N;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

if (N == 1)
{
    Console.Write("Работаем");
}
if (N == 2)
{
    Console.Write("Работаем");
}
if (N == 3)
{
    Console.Write("Работаем");
}
if (N == 4)
{
    Console.Write("Работаем");
}
if (N == 5)
{
    Console.Write("Работаем");
}
if (N == 6)
{
    Console.Write("Выходной");
}
if (N == 7)
{
    Console.Write("Выходной");
}
if (N > 7)
{
    Console.Write("Попробуйте еще раз");
}