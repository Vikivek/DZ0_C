/* Задача 2:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
int a = 1;
int b = -9;
int max = a;

if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);
*/

/* Задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
int number1, number2, number3;

Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out number1);

Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out number2);

Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out number3);

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("max = ");
Console.WriteLine(max);
*/

/* Задача 6:
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
int numberA;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out numberA);

if (numberA % 2 == 0)
{
    Console.WriteLine(numberA + " - Четное число: ");
}
else
{
    Console.WriteLine(numberA + " - Нечетное число: ");
}
*/

/*
Задача 8:
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
int startNumber = 1;

while (startNumber <= number)
{
    if (startNumber % 2 == 0)
        Console.Write(startNumber + ", ");
    startNumber++;
}