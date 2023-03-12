Console.Clear();
/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2     */
/*
int[,] array = new int[4, 4];

FillArrayRandom(array);
Sort(array);
Console.WriteLine();
PrintArray(array);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m + 1];
                    array[i, m + 1] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
/*
Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int[,] array = new int[4, 4];

FillArrayRandom(array);
Console.WriteLine();
MinSumElements(array);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumElements(int[,] array)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"{minSum + 1} строка");
}
*/
/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] a = new int[2, 2];
int[,] b = new int[2, 2];


if (a.GetLength(0) != b.GetLength(1))
{
    Console.WriteLine("Матрицы не перемножаться");
    return;
}
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().Next(10);
    }
}
for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = new Random().Next(10);
    }
}

int[,] c = new int[a.GetLength(0), b.GetLength(1)];

for (int i = 0; i < c.GetLength(0); i++)
    for (int j = 0; j < c.GetLength(1); j++)
        for (int k = 0; k < a.GetLength(1); k++)
            c[i, j] += a[i, k] * b[k, j];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)

        Console.Write($"{a[i, j]} ");
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)

        Console.Write($"{b[i, j]} ");
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)

        Console.Write($"{c[i, j]} ");
    Console.WriteLine();
}
*/
/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int[,,] arr = new int[2, 2, 2];

int count = 10;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            arr[i, j, k] = count;
            count += 3;
        }
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.WriteLine();

        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
        }
    }
}
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] arr = new int[4, 4];

int num = 1;
int i = 0;
int j = 0;


while (num <= arr.GetLength(0) * arr.GetLength(1))
{
    arr[i, j] = num;
    if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
        ++j;
    else
    if (i < j && i + j >= arr.GetLength(0) - 1)
        ++i;
    else
    if (i >= j && i + j > arr.GetLength(1) - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(arr);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", array[i, j]));
        }
        Console.WriteLine("");
    }
}