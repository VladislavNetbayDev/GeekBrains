// Задача 2: Напишите программу, 
// которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int inputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FactorialN(int value)
{
    int value2 = 1;
    for (int i = 1; i <= value; i++)
    {
        value2 = value2 * i;
    }
    return value2;
}
int N = inputValue("Введите число: ");
int factorial = FactorialN(N);
System.Console.WriteLine($"Произведение числа от 1 до {N} равно {factorial}");
