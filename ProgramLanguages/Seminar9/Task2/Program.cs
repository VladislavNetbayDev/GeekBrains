// Задайте значения M и N. 
// Напишите программу, которая рекурсивно 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int InputValue(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int numberStart, int numberFinish)
{
    if(numberStart == numberFinish)
    {
        return;
    }
    
    System.Console.Write($"{numberStart}; ");
    PrintNumbers(numberStart + 1, numberFinish);
    
}
int numberStart = 4;
int numberFinish = 9;
// int number = InputValue("Введите число: ");
PrintNumbers(numberStart, numberFinish);
