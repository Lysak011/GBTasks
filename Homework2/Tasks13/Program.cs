// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
//int a = a/10;
//int a = a%10;


if (a < 99)
{
    WriteLine ("-> третьей цифры нет");
    return;
}
while (a < 999)
{
    WriteLine (a = a%10);
    return;
}
while (a < 9999);
{
    WriteLine ($"{a = a/100%10}");
}