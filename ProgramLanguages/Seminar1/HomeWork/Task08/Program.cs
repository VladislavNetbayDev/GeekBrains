// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Четные числа от 1 до {N} ");
for (int A = 2; A <= N; A +=2)
{
    System.Console.Write($"{A} ");
}
