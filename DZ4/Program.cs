Console.Clear();
/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*//*
int[] array = FillArray(4, 100, 999);

Print(array);
int count = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
        count++;
}

Console.Write($"Всего чётных чисел; {count}");

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}
*//*
Задача 36:
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] array = FillArray(4, -10, 20);

Print(array);
int sum = 0;

for (int j = 1; j < array.Length; j += 2)
{
    sum += array[j];
}

Console.Write($"Сумма элементов на нечётных позициях = {sum}");

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(1, 10);
    return arr;
}
*/ /*Задача 38: 
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] array = FillArray(5);

Print(array);
double max = 0;
double min = 11;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
}

Console.Write($"{max - min}");

void Print(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine("]");
}

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(10, 100) / 10;
    return arr;
}