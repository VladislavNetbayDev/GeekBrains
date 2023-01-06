//  Задайте значения M и N. 
//  Напишите программу, 
//  которая выведет все чётные натуральные числа 
//  в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputValue(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int N, int M)
{
    if(N < M)
    {
        return;
    }
    PrintNumbers(N - 1, M);
    if (N % 2 ==0) System.Console.Write($"{N}; ");
}

int N = InputValue("Введите число N: ");
int M = InputValue("введите число M: ");
PrintNumbers(N, M);