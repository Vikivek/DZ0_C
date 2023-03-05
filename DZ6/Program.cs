Console.Clear();
/* Задача 47. 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5  7  -2  -0,2
1  -3,3  8  -9,9
8  7,8  -7,1  9
*/
/*

double[,] arr = new double[3, 4];


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().NextDouble() * 10 - 5;
        Console.Write("{0,7:F1}", arr[i, j]);
    }
    Console.WriteLine();
}
*/

/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
/*
int a, b;
Console.Write($"Введите количество строк: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out b);

int n = 3;
int m = 4;
int[,] array = new int[n, m];

FillArray(array);
PrintArray(array);

if (a < array.GetLength(0) && b < array.GetLength(1))
{ Console.WriteLine($"{array[a, b]}"); }

else
{ Console.WriteLine($"{a},{b} -> такой числа в массиве нет"); }


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
}
*/

/* Задача 52.
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0.0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];
    }
    Console.WriteLine($"{sum / array.GetLength(0)}");
}

