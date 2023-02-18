/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.Write("Введите число: ");
string N = Console.ReadLine()!;
int size = N.Length;

if (size == 5)
{
    if (N[0] == N[4] && N[1] == N[3])
    {
        Console.WriteLine($"{N} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{N} - Не является палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {N} - не является пятизначным числом");
}

/*
Задача 21
Напишите программу, 
которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
Console.Clear();

double[] A = new double[3];
double[] B = new double[3];

Console.Write($"Введите координату x точки А: ");
double.TryParse(Console.ReadLine()!, out A[0]);

Console.Write($"Введите координату y точки А: ");
double.TryParse(Console.ReadLine()!, out A[1]);

Console.Write($"Введите координату z точки А: ");
double.TryParse(Console.ReadLine()!, out A[2]);

Console.Write($"Введите координату x точки B: ");
double.TryParse(Console.ReadLine()!, out B[0]);

Console.Write($"Введите координату y точки B: ");
double.TryParse(Console.ReadLine()!, out B[1]);

Console.Write($"Введите координату z точки B: ");
double.TryParse(Console.ReadLine()!, out B[2]);


double Xdist = Math.Pow(A[0] - B[0], 2);
double Ydist = Math.Pow(A[1] - B[1], 2);
double Zdist = Math.Pow(A[2] - B[2], 2);
double ans = Math.Sqrt(Xdist + Ydist + Zdist);

Console.Write($"A({A[0]};{A[1]};{A[2]})B({B[0]};{B[1]};{B[2]}) -> {ans}");
*/
/*Задача 21
Напишите программу, 
которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
Console.Clear();

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int i = 1; i <= N; i++)
    Console.Write($"{i * i * i} ");
*/