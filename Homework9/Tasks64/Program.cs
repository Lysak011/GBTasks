// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число от 1: ");
int number = int.Parse(Console.ReadLine());

void NumberCounter (int number)
{
    if (number == 0) 
    return;
    Console.Write("{0,2}", number);

    NumberCounter (number - 1);
}
NumberCounter(number);