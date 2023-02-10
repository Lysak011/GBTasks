// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using static System.Console;
Clear();

Write ("Введите число А: ");
int a =int.Parse(ReadLine()!);
Write ("Введите число B: ");
int b =int.Parse(ReadLine()!);

int a_b=1;
for (int i=1; i<=b; i++)
{
    a_b*=a;
}
    
int Degree = a_b;
Console.WriteLine($"-> {Degree}");
