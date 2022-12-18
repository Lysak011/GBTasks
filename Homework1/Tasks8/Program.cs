//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
for(int n = 1; n <= a; n++) 
{
    if(n % 2 == 0) 
    {
    Write("{0} ", n);
    }
}
  ReadKey();
  return 0;