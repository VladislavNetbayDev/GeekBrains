﻿// Задача 1: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int InputValue(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int number)
{
    if(number == 0)
    {
        return;
    }
    //System.Console.Write($"{number}; ");
    PrintNumbers(number - 1);
    System.Console.Write($"{number}; ");
}

int number = InputValue("Введите число: ");
PrintNumbers(number);
