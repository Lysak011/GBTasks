﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


using static System.Console;

WriteLine("Какое из этих чисел максимальное?");
WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);
WriteLine("Введите число с: ");
int c = int.Parse(ReadLine()!);


if (a > b && a > c)
{
    Write($"max = {a}");
}
else 
    if (b > c)
    {
       WriteLine($"max = {b}");
    }
    else 
    {
        WriteLine($"max = {c}");
    }