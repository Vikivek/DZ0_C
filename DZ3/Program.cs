/*Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*//*
int a = TakeInt();
int b = TakeInt($"Введите степень: ");

int result = a;
for (int i = 1; i < b; i++)
{
    result *= a;
}

Console.WriteLine(a + " в степени " + b + " = " + result);

int TakeInt(string _str = "Введите число: ")
{
    int num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
*/
/*Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 
*/ /*
int a = TakeInt();

Console.Write($"{a} -> {Sum(a)}");

int Sum(int _a)
{
    int sum = 0;
    while (_a != 0)
    {
        sum += _a % 10;
        _a /= 10;
    }
    return sum;
}

int TakeInt(string _str = "Введите число: ")
{
    int num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
*/
/*
Задача 29:
Напишите программу,
которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
//int a = TakeInt();
int lenArr = TakeInt("Введите длинну массива: ");

int[] randomArr = new int[lenArr];
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(1, 30);
    Console.Write(randomArr[i] + " ");
}

int TakeInt(string _str = "Введите числа: ")
{
    int num;
    Console.Write(_str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}