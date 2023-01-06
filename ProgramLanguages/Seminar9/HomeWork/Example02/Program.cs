// Задайте значения M и N. +
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputValue(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumRecursia(int N, int M)
{
    if (N < M) return 0;
    else return N + SumRecursia(N - 1, M);
}

int N = InputValue("Введите число N: ");
int M = InputValue("Введите число M: ");
System.Console.WriteLine(SumRecursia(N, M));
 